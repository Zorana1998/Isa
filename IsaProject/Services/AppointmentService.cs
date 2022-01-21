using IsaProject.Data;
using IsaProject.Models;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AppointmentService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<int> Update(Appointment appointment)
        {
           
            _context.Update(appointment);
            await _context.SaveChangesAsync();
            

            return await _context.SaveChangesAsync();
        }

        public bool Exists(long id)
        {
            return _context.Appointments.Any(m => m.Id == id);
        }

        public async Task<List<ScheduledAppointment>> GetMyReservation(string id)
        {
            List<ScheduledAppointment> appointments = await (from u in _context.scheduledAppointments
                                         where u.UserID == id && u.Start >= System.DateTime.Now && u.IsActive == true
                                         select u).ToListAsync();

            return appointments;
        }

        public async Task<List<ScheduledAppointment>> GetMyHistoryReservationCottages(string id)
        {
            List<ScheduledAppointment> appointments = await (from u in _context.scheduledAppointments
                                                             join entity in _context.Cottages on u.EntityID equals entity.Id
                                                             where u.UserID == id && u.Start < System.DateTime.Now && u.IsActive == true
                                                             select u).ToListAsync();

            return appointments;
        }

        public async Task<List<ScheduledAppointment>> GetMyHistoryReservationShips(string id)
        {
            List<ScheduledAppointment> appointments = await (from u in _context.scheduledAppointments
                                                             join entity in _context.ShipBooking on u.EntityID equals entity.Id
                                                             where u.UserID == id && u.Start < System.DateTime.Now && u.IsActive == true
                                                             select u).ToListAsync();

            return appointments;
        }

        public async Task<List<ScheduledAppointment>> GetMyHistoryReservationAdventures(string id)
        {
            List<ScheduledAppointment> appointments = await (from u in _context.scheduledAppointments
                                                             join entity in _context.Adventure on u.EntityID equals entity.Id
                                                             where u.UserID == id && u.Start < System.DateTime.Now && u.IsActive == true
                                                             select u).ToListAsync();

            return appointments;
        }

        public async Task<List<Appointment>> GetMyAppointmentOwner(string id)
        {
            List<Appointment> appointments = await (from u in _context.Appointments
                                                             where u.OwnerID == id && u.Start > System.DateTime.Now
                                                             select u).ToListAsync();

            List<FastReservation> fastReservations = await (from u in _context.FastReservations
                                                            where u.OwnerID == id && u.Start > System.DateTime.Now
                                                            select u).ToListAsync();

            List<Appointment> appointmentsWithoutFast = new List<Appointment>();

            int counter = 0;

            foreach(Appointment app in appointments)
            {
                counter = 0;
                foreach(FastReservation fast in fastReservations)
                {
                    if(app.Id == fast.Id)
                    {
                        counter++;
                    }
                }

                if(counter == 0)
                {
                    appointmentsWithoutFast.Add(app);
                }
            }




            return appointmentsWithoutFast;
        }

        public Appointment GetById(long id)
        {
            var app = _context.Appointments.Find(id);

            return app;
        }


        public async Task<List<ScheduledAppointment>> GetMyHistoryReservationOwner(string id)
        {
            List<ScheduledAppointment> appointments = await (from u in _context.scheduledAppointments
                                                             where u.UserID == id && u.Start < System.DateTime.Now && u.IsActive == true
                                                             select u).ToListAsync();

            return appointments;
        }

    }
}
