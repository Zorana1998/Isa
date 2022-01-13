using Microsoft.AspNetCore.Identity;
using IsaProject.Data;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IsaProject.Models.Entities;
using IsaProject.Models.DTO;
using Newtonsoft.Json;
using Isa.Areas.Identity;
using IsaProject.Models;

namespace IsaProject.Services
{
    public class CottageService : ICottageService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CottageService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<AppointmentDTO>> GetAvailableCottages(string id,DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {

            //AllScheduledCottages
            List<ScheduledAppointment> scheduledAppointments = await (from schApp in _context.scheduledAppointments
                                                                      join cottage in _context.Cottages on schApp.EntityID equals cottage.Id
                                                                      where schApp.IsActive == true
                                                                      select schApp).ToListAsync();

            //FastReservation
            List<long> fastReservationsIds = new List<long>();
            fastReservationsIds = await (from res in _context.FastReservations
                                      select res.Id).ToListAsync();

            //AllWithFast
            List<Appointment> cottagesAppointmentTemporary;
            cottagesAppointmentTemporary = await (from cottage in _context.Cottages
                                         join cottageAppointment in _context.Appointments on cottage.Id equals cottageAppointment.EntityID
                                         where cottage.AverageScore > averageScore
                                         && cottageAppointment.MaxNumberOfPeople > numberOfGuest
                                         && cottageAppointment.Start <= dateTime
                                         //&& cottageAppointment.Start >= DateTime.Now
                                         && cottageAppointment.Start.AddDays(cottageAppointment.DurationDays) >= dateTime.AddDays(numberOfDays)
                                         select cottageAppointment).ToListAsync();
            //SkipFast
            List<Appointment> cottagesAppointment = new List<Appointment>();

            foreach(Appointment app in cottagesAppointmentTemporary)
            {
                if (!fastReservationsIds.Contains(app.Id))
                {
                    cottagesAppointment.Add(app);
                }
            }

            List<Appointment> availableAppointments = new List<Appointment>();

            var counter = 0;

            foreach (Appointment appointment in cottagesAppointment)
            {
                counter = 0;

                foreach (ScheduledAppointment scheduledAppointment in scheduledAppointments)
                {
                    if (appointment.EntityID == scheduledAppointment.EntityID)
                    {
                        //upao u sredinu
                        if (scheduledAppointment.Start >= dateTime && scheduledAppointment.Start.AddDays(scheduledAppointment.Duration) <= dateTime.AddDays(numberOfDays))
                        {
                            counter++;
                        }

                        //kraj unutar
                        if (scheduledAppointment.Start <= dateTime && scheduledAppointment.Start.AddDays(scheduledAppointment.Duration) <= dateTime.AddDays(numberOfDays))
                        {
                            counter++;
                        }

                        //upao pocetak
                        if (scheduledAppointment.Start < dateTime.AddDays(numberOfDays) && scheduledAppointment.Start.AddDays(scheduledAppointment.Duration) >= dateTime.AddDays(numberOfDays))
                        {
                            counter++;
                        }


                        //novi u sredinu
                        if (scheduledAppointment.Start < dateTime && scheduledAppointment.Start.AddDays(scheduledAppointment.Duration) > dateTime.AddDays(numberOfDays))
                        {
                            counter++;
                        }
                    }

                }

                if (counter == 0)
                {
                    availableAppointments.Add(appointment);
                }
            }

            //AllCottagesAppDTO
            List<AppointmentDTO> cottagesAppointmentDTO = new List<AppointmentDTO>();

            foreach(Appointment app in availableAppointments)
            {
                //MyLastAppointment, to skip in same time
                List<ScheduledAppointment> myAppointments = await (from schApp in _context.scheduledAppointments
                                                                   join cottage in _context.Cottages on schApp.EntityID equals cottage.Id
                                                                   where schApp.IsActive == false && schApp.UserID == id && schApp.Start == dateTime && schApp.EntityID == app.EntityID
                                                                   select schApp).ToListAsync();

                

                if (myAppointments.Count != 0)
                {
                    continue;
                }

                List<Cottage> cottages = await (from cottage in _context.Cottages
                                               join cottageAppointment in _context.Appointments on cottage.Id equals cottageAppointment.EntityID
                                               where cottageAppointment.Id == app.Id
                                               select cottage).ToListAsync();
                Cottage cottage1 = cottages.First();

                AppointmentDTO appDTO = new AppointmentDTO(app.Id, cottage1.Name, cottage1.Address, cottage1.Country, cottage1.City, cottage1.AverageScore, cottage1.Rules, app.Price, dateTime, numberOfDays, id, numberOfGuest);
                cottagesAppointmentDTO.Add(appDTO);
            }
            
            

            List<AppointmentDTO> present = new List<AppointmentDTO>();


            foreach( AppointmentDTO appointmentDTO in cottagesAppointmentDTO)
            {
                var app = new AppointmentDTO(appointmentDTO.AppointmentId, appointmentDTO.Name, appointmentDTO.Address, appointmentDTO.Country, appointmentDTO.City, appointmentDTO.AverageScore, appointmentDTO.Rules, appointmentDTO.Price, appointmentDTO.StartDate, appointmentDTO.Duration, id, numberOfGuest);
                _context.cottageAppointmentDTOs.Add(app);
                _context.SaveChanges();
                var appDTOiD = app.Id;
                present.Add(_context.cottageAppointmentDTOs.Find(appDTOiD));
            }


            return present;
        }

        public async Task<List<Cottage>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var cottages = new List<Cottage>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    cottages = await _context.Cottages.ToListAsync();
                }
            }
            else
            {
                cottages = await _context.Cottages.ToListAsync();
            }

            List<Cottage> filteredCottages = new List<Cottage>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredCottages = cottages;
            }
            else
            {
                foreach (var cottage in cottages)
                {
                    var json = JsonConvert.SerializeObject(cottage);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredCottages.Add(cottage);
                    }
                }
            }

            return filteredCottages;
        }

        /*public async Task<List<AppointmentDTO>> GetAvailableCottagesFiltered(string searchString, string filter, string sort)
        {

            var cottages = new List<AppointmentDTO>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    cottages = await _context.Cottages.ToListAsync();
                }
            }
            else
            {
                cottages = await _context.Cottages.ToListAsync();
            }

            List<Cottage> filteredCottages = new List<Cottage>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredCottages = cottages;
            }
            else
            {
                foreach (var cottage in cottages)
                {
                    var json = JsonConvert.SerializeObject(cottage);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredCottages.Add(cottage);
                    }
                }
            }

            return cottages;
        }*/


    }


    
}