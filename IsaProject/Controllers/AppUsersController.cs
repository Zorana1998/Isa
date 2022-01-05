using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using IsaProject.Data;
using IsaProject.Models;
using IsaProject.Models.Users;
using IsaProject.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IsaProject.Controllers
{
    public class AppUsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUsersService _appUsersService;


        public AppUsersController(ApplicationDbContext context, UserManager<AppUser> userManager, IAppUsersService appUsersService)
        {
            _context = context;
            _userManager = userManager;
            _appUsersService = appUsersService;
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.tbAppUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            List<string> userRole = await (from userrole in _context.UserRoles
                                           join role in _context.Roles on userrole.RoleId equals role.Id
                                           where userrole.UserId == id
                                           select role.Name).ToListAsync();
            ViewData["roleName"] = userRole.Count == 0 ? "" : userRole[0];

            return View(appUser);
        }

        // GET: AppUsers/UserList
        public async Task<IActionResult> UserList()
        {
            List<string> entryPoint = await (from userrole in _context.UserRoles
                                             join role in _context.Roles on userrole.RoleId equals role.Id
                                             where role.Name == "User"
                                             select userrole.UserId).ToListAsync();

            ViewData["roleName"] = "User";
            return View(await _context.tbAppUsers.Where(e => entryPoint.Contains(e.Id)).ToListAsync());
        }


        [HttpGet("AppUsers/Edit")]
        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.Id == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("AppUsers/Edit")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public async Task<IActionResult> Edit([Bind("Id,FirstName,LastName,Address,Country,City,PhoneNumber")] AppUser appUser)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.Id != appUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var repositoryUser = await _appUsersService.GetById(user.Id);

                    repositoryUser.FirstName = appUser.FirstName;
                    repositoryUser.PhoneNumber = appUser.PhoneNumber;
                    repositoryUser.LastName = appUser.LastName;
                    repositoryUser.Address = appUser.Address;
                    repositoryUser.City = appUser.City;
                    repositoryUser.LastName = appUser.LastName;
                    repositoryUser.Country = appUser.Country;

                    await _appUsersService.Update(repositoryUser);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_appUsersService.Exists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return View("ConcurrencyError", "Home");
                    }
                }
                return RedirectToAction();
            }
            return View(appUser);
        }

        [HttpGet("AppUsers/Delete/{id}")]
        // GET: Drugs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.tbAppUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: Drugs/Delete/5
        [HttpPost("AppUsers/Delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var appUser = await _context.tbAppUsers.FindAsync(id);
            _context.tbAppUsers.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction("UserList");
        }

        protected bool AppUserExists(string id)
        {
            return _context.tbAppUsers.Any(e => e.Id == id);
        }

    }
}