using Microsoft.AspNetCore.Identity;
using IsaProject.Data;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace IsaProject.Services
{
    public class AppUsersService : IAppUsersService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AppUsersService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<string> GetUserRole(string id)
        {
            List<string> userRole = await (from userrole in _context.UserRoles
                                           join role in _context.Roles on userrole.RoleId equals role.Id
                                           where userrole.UserId == id
                                           select role.Name).ToListAsync();

            return userRole.FirstOrDefault();
        }

        public async Task<AppUser> GetById(string id)
        {
            return await _context.tbAppUsers.FindAsync(id);
        }

        public async Task<List<AppUser>> GetByList(List<string> idList)
        {
            List<AppUser> users = await _context.tbAppUsers
                                          .Where(l => idList.Any(id => id == l.Id))
                                          .ToListAsync();

            return users;
        }

        public async Task<int> Update(AppUser user)
        {
            _context.Update(user);

            return await _context.SaveChangesAsync();
        }

        public bool Exists(string id)
        {
            return _context.tbAppUsers.Any(e => e.Id == id);
        }

        public async void Create(AppUser user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AppUser>> GetUnapprovedUsers()
        {
            List<AppUser> users = await (from u in _context.tbAppUsers
                                         join userRole in _context.UserRoles on u.Id equals userRole.UserId
                                         join role in _context.Roles on userRole.RoleId equals role.Id
                                         where (role.Name != "Admin" || role.Name !="User") &&
                                         u.EmailConfirmed == false && u.ReasonForReject == null
                                         select u).ToListAsync();

            return users;
        }

        public AppUser GetByUsername(string username)
        {
            var user = from u in _context.tbAppUsers
                       where u.UserName.Equals(username)
                       select u;

            if (user.Count() == 0)
            {
                return null;
            }
            return user.First();
        }

    }
}