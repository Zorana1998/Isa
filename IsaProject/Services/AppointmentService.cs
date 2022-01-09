using IsaProject.Data;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
    }
}
