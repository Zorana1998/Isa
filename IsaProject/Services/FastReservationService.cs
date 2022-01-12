
using IsaProject.Data;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public class FastReservationService : IFastReservationService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public FastReservationService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<int> Update(FastReservation fastReservation)
        {

            _context.Update(fastReservation);
            await _context.SaveChangesAsync();


            return await _context.SaveChangesAsync();
        }

        public bool Exists(long id)
        {
            return _context.FastReservations.Any(m => m.Id == id);
        }

        public async Task<List<FastReservation>> GetMyFastReservation(string id)
        {
            List<FastReservation> fastReservations = await (from u in _context.FastReservations
                                                    where u.UserID == id && u.Start >= System.DateTime.Now && u.isScheduled == true
                                                    select u).ToListAsync();

            return fastReservations;
        }
    }
}
