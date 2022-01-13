using IsaProject.Data;
using IsaProject.Models;
using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
using IsaProject.Models.Entities.Adventure;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public class AdventureService : IAdventureService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AdventureService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Adventure>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var adventures = new List<Adventure>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    adventures = await _context.Adventure.ToListAsync();
                }
            }
            else
            {
                adventures = await _context.Adventure.ToListAsync();
            }

            List<Adventure> filteredAdventures = new List<Adventure>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredAdventures = adventures;
            }
            else
            {
                foreach (var adventure in adventures)
                {
                    var json = JsonConvert.SerializeObject(adventure);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredAdventures.Add(adventure);
                    }
                }
            }

            return filteredAdventures;
        }

        public async Task<List<AppointmentDTO>> GetAvailableAdventure(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore, string id)
        {
            //AllScheduledAdventures
            List<ScheduledAppointment> scheduledAppointments = await (from schApp in _context.scheduledAppointments
                                                                      join adventure in _context.Adventure on schApp.EntityID equals adventure.Id
                                                                      where schApp.IsActive == true
                                                                      select schApp).ToListAsync();

            //FastReservation
            List<long> fastReservationsIds = new List<long>();
            fastReservationsIds = await (from res in _context.FastReservations
                                         select res.Id).ToListAsync();



            List<Appointment> adventuresAppointmentTemporary;
            adventuresAppointmentTemporary = await (from adventure in _context.Adventure
                                           join adventureAppointment in _context.Appointments on adventure.Id equals adventureAppointment.EntityID
                                         where adventure.AverageScore > averageScore
                                         && adventureAppointment.MaxNumberOfPeople > numberOfGuest
                                         && adventureAppointment.Start <= dateTime
                                         && adventureAppointment.Start >= DateTime.Now
                                         && adventureAppointment.Start.AddDays(adventureAppointment.DurationDays) >= dateTime.AddDays(numberOfDays)
                                         select adventureAppointment).ToListAsync();
            //SkipFast
            List<Appointment> adventuresAppointment = new List<Appointment>();

            foreach (Appointment app in adventuresAppointmentTemporary)
            {
                if (!fastReservationsIds.Contains(app.Id))
                {
                    adventuresAppointment.Add(app);
                }
            }

            List<Appointment> availableAppointments = new List<Appointment>();

            var counter = 0;

            foreach (Appointment appointment in adventuresAppointment)
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

            //AllAdventureAppDTO
            List<AppointmentDTO> adventureAppointmentDTO = new List<AppointmentDTO>();

            foreach (Appointment app in availableAppointments)
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

                List<Adventure> adventures = await (from adventure in _context.Adventure
                                                join adventureAppointment in _context.Appointments on adventure.Id equals adventureAppointment.EntityID
                                                where adventureAppointment.Id == app.Id
                                                select adventure).ToListAsync();
                Adventure adventure1 = adventures.First();

                AppointmentDTO appDTO = new AppointmentDTO(app.Id, adventure1.Name, adventure1.Address, adventure1.Country, adventure1.City, adventure1.AverageScore, adventure1.Rules, app.Price, dateTime, numberOfDays, id, numberOfGuest);
                adventureAppointmentDTO.Add(appDTO);
            }



            List<AppointmentDTO> present = new List<AppointmentDTO>();


            foreach (AppointmentDTO appointmentDTO in adventureAppointmentDTO)
            {
                var app = new AppointmentDTO(appointmentDTO.AppointmentId, appointmentDTO.Name, appointmentDTO.Address, appointmentDTO.Country, appointmentDTO.City, appointmentDTO.AverageScore, appointmentDTO.Rules, appointmentDTO.Price, appointmentDTO.StartDate, appointmentDTO.Duration, id, numberOfGuest);
                _context.cottageAppointmentDTOs.Add(app);
                _context.SaveChanges();
                var appDTOiD = app.Id;
                present.Add(_context.cottageAppointmentDTOs.Find(appDTOiD));
            }


            return present;
        }

    }
}
