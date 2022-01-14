using IsaProject.Data;
using IsaProject.Models;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsaProject.Services
{
    public class SchedulerService: ISchedulerService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public SchedulerService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public void AddPenalty()
        {
            List<ScheduledAppointment> scheduledAppointments = (from u in _context.scheduledAppointments
                                                 where u.IsCome != true
                                                 select u).ToList();

            List<string> appointmentsUsersIds = new List<string>();

            foreach(ScheduledAppointment scheduledAppointment in scheduledAppointments)
            {
                Console.WriteLine(Math.Abs((int)((scheduledAppointment.Start - DateTime.Now).TotalDays)));
                if (Math.Abs((int)((scheduledAppointment.Start - DateTime.Now).TotalDays)) == 0)
                {
                    appointmentsUsersIds.Add(scheduledAppointment.UserID);
                }
            }
            

            foreach (string id in appointmentsUsersIds)
            {
                AppUser appUser = _context.tbAppUsers.Find(id);

                appUser.Penalty++;

                _context.Update(appUser);
                _context.SaveChangesAsync();
            }
        }

        public void DeletePenalty()
        {
            List<AppUser> appUsers = (from u in _context.tbAppUsers select u).ToList();

            foreach(AppUser appUser in appUsers)
            {
                appUser.Penalty = 0;
                _context.Update(appUser);
                _context.SaveChangesAsync();
            }
        }
    }
}
