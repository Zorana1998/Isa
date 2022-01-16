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
using Isa.Areas.Identity;
using System.IO;
using IsaProject.Models.Entities;

namespace IsaProject.Controllers
{
    public class AppUsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUsersService _appUsersService;
        private readonly EmailSender _emailSender;


        public AppUsersController(ApplicationDbContext context, UserManager<AppUser> userManager, IAppUsersService appUsersService)
        {
            _context = context;
            _userManager = userManager;
            _appUsersService = appUsersService;
            using (StreamReader r = new StreamReader("./Areas/Identity/emailCredentials.json"))
            {
                string json = r.ReadToEnd();
                _emailSender = JsonConvert.DeserializeObject<EmailSender>(json);
            }
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.tbAppUsers.ToListAsync());

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
        [ApiExplorerSettings(IgnoreApi = true)]
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

        [ApiExplorerSettings(IgnoreApi = true)]
        protected bool AppUserExists(string id)
        {
            return _context.tbAppUsers.Any(e => e.Id == id);
        }


        public async Task<IActionResult> GetUnapprovedUsers()
        {
            return View(await _appUsersService.GetUnapprovedUsers());
        }

        public async Task<IActionResult> ApproveRegistration(string? id)
        {
            var user = await _context.tbAppUsers
                .FirstOrDefaultAsync(m => m.Id == id);

            user.EmailConfirmed = true;
            try
            {
                await _appUsersService.Update(user);
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
            await _emailSender.SendEmailAsync(user.Email, "Profile approved",
                $"Profile approved for {user.Email}");

            return View();
        }

        [HttpGet("AppUsers/Reject")]
        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Reject(string id)
        {
            
            var repositoryUser = await _appUsersService.GetById(id);

            if (repositoryUser == null)
            {
                return NotFound();
            }

            return View(repositoryUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("AppUsers/Reject")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public async Task<IActionResult> Reject([Bind("Id, ReasonForReject")] AppUser appUser)
        {
            Console.WriteLine(appUser);

            var user = await _appUsersService.GetById(appUser.Id);

            if (ModelState.IsValid)
            {
                try
                {
                    var repositoryUser = await _appUsersService.GetById(user.Id);

                    repositoryUser.ReasonForReject = appUser.ReasonForReject;

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
                await _emailSender.SendEmailAsync(user.Email, "Profile reject",
                $"Profile reject for {user.Email} because {user.ReasonForReject}");
                return View("Home");
            }
            

            return View("Home");
        }

        public IActionResult DeleteProfile()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProfile([Bind("Id,Content,IsApproved")] ProfileDelete profileDelete)
        {
            var user = await _userManager.GetUserAsync(User);
            ProfileDelete profileDeleteNew = new()
            {
                IsApproved = false,
                UserId = user.Id,
                Content = profileDelete.Content
            };

            _context.Add(profileDeleteNew);
            _context.SaveChanges();
            return View();
        }
        public async Task<IActionResult> GetProfilesForDelete()
        {
            List<ProfileDelete> profileDeletes = await (from u in _context.ProfileDelete
                                          where u.IsApproved == false
                                          select u).ToListAsync();

            return View(profileDeletes);
        }


        public async Task<IActionResult> ApproveDelete(long Id)
        {
            ProfileDelete profileDelete = _context.ProfileDelete.Find(Id);

            profileDelete.IsApproved = true;

            _context.ProfileDelete.Update(profileDelete);
            _context.SaveChanges();

            

            string userId = profileDelete.UserId;

            AppUser appUser = _context.tbAppUsers.Find(userId);
            


            await _emailSender.SendEmailAsync(appUser.Email, "Profile delete",
                $"Profile delete for {appUser.Email}");

            appUser.Email = null;
            appUser.UserName = null;


            _context.Update(appUser);
            _context.SaveChanges();

            return RedirectToAction(nameof(GetProfilesForDelete));
        }


        

    }

}