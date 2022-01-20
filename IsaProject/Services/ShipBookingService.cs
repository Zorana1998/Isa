using IsaProject.Data;
using IsaProject.Models;
using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
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
    public class ShipBookingService : IShipBookingService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ShipBookingService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<ShipBooking>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var shipBookings = new List<ShipBooking>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    shipBookings = await _context.ShipBooking.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    shipBookings = await _context.ShipBooking.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    shipBookings = await _context.ShipBooking.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    shipBookings = await _context.ShipBooking.ToListAsync();
                }
            }
            else
            {
                shipBookings = await _context.ShipBooking.ToListAsync();
            }

            var filteredShips = new List<ShipBooking>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredShips = shipBookings;
            }
            else
            {
                foreach (var ship in shipBookings)
                {
                    var json = JsonConvert.SerializeObject(ship);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredShips.Add(ship);
                    }
                }
            }

            return filteredShips;
        }

        public async Task<List<AppointmentDTO>> GetAvailableShips(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore, String id)
        {

            //AllScheduledCottages
            var scheduledAppointments = await (from schApp in _context.scheduledAppointments
                                                                      join ships in _context.ShipBooking on schApp.EntityID equals ships.Id
                                                                      where schApp.IsActive == true
                                                                      select schApp).ToListAsync();

            //FastReservation
            var fastReservationsIds = new List<long>();
            fastReservationsIds = await (from res in _context.FastReservations
                                         select res.Id).ToListAsync();



            List<Appointment> shipAppointmentsTemporary;
            shipAppointmentsTemporary = await (from ship in _context.ShipBooking
                                      join shipAppointment in _context.Appointments on ship.Id equals shipAppointment.EntityID
                                      where ship.AverageScore > averageScore
                                      && shipAppointment.MaxNumberOfPeople > numberOfGuest
                                      && shipAppointment.Start <= dateTime
                                      && shipAppointment.Start >= DateTime.Now
                                      && shipAppointment.Start.AddDays(shipAppointment.DurationDays) >= dateTime.AddDays(numberOfDays)
                                      select shipAppointment).ToListAsync();

            //SkipFast
            var shipAppointments= new List<Appointment>();

            foreach (Appointment app in shipAppointmentsTemporary)
            {
                if (!fastReservationsIds.Contains(app.Id))
                {
                    shipAppointments.Add(app);
                }
            }

            List<Appointment> availableAppointments = new();

            
            foreach (Appointment appointment in shipAppointments)
            {
                var counter = 0;

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
                        if (scheduledAppointment.Start <= dateTime && scheduledAppointment.Start.AddDays(scheduledAppointment.Duration) >= dateTime.AddDays(numberOfDays))
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
            var shipAppointmentDto = new List<AppointmentDTO>();

            foreach (Appointment app in availableAppointments)
            {
                //MyLastAppointment, to skip in same time
                List<ScheduledAppointment> myAppointments = await (from schApp in _context.scheduledAppointments
                                                                   join ship in _context.ShipBooking on schApp.EntityID equals ship.Id
                                                                   where schApp.IsActive == false && schApp.UserID == id && schApp.Start == dateTime && schApp.EntityID == app.EntityID
                                                                   select schApp).ToListAsync();



                if (myAppointments.Count != 0)
                {
                    continue;
                }

                List<ShipBooking> ships = await (from ship in _context.ShipBooking
                                                 join shipAppointment in _context.Appointments on ship.Id equals shipAppointment.EntityID
                                                 where shipAppointment.Id == app.Id
                                                 select ship).ToListAsync();
                ShipBooking shipBooking = ships.First();

                AppointmentDTO appDTO = new AppointmentDTO(app.Id, shipBooking.Name, shipBooking.Address, shipBooking.Country, shipBooking.City, shipBooking.AverageScore, shipBooking.Rules, app.Price, dateTime, numberOfDays, id, numberOfGuest);
                shipAppointmentDto.Add(appDTO);
            }



            var present = new List<AppointmentDTO>();


            foreach (AppointmentDTO appointmentDto in shipAppointmentDto)
            {
                var app = new AppointmentDTO(appointmentDto.AppointmentId, appointmentDto.Name, appointmentDto.Address, appointmentDto.Country, appointmentDto.City, appointmentDto.AverageScore, appointmentDto.Rules, appointmentDto.Price, appointmentDto.StartDate, appointmentDto.Duration, id, numberOfGuest);
                _context.cottageAppointmentDTOs.Add(app);
                _context.SaveChanges();
                var appDTOiD = app.Id;
                present.Add(_context.cottageAppointmentDTOs.Find(appDTOiD));
            }


            return present;
        }
    }

}



