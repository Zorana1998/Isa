using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Models.Entities;
using IsaProject.Services;
using Microsoft.AspNetCore.Identity;
using IsaProject.Models.Users;
using IsaProject.Models.DTO;
using Microsoft.AspNetCore.Authorization;

namespace IsaProject.Controllers
{
    public class CottagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICottageService _cottageService;
        private readonly UserManager<AppUser> _userManager;

        public CottagesController(ApplicationDbContext context, ICottageService cottageService, UserManager<AppUser> userManager)
        {
            _context = context;
            _cottageService = cottageService;
            _userManager = userManager;
        }

        // GET: Cottages1
        public async Task<IActionResult> Index(string searchString = "", string filter = "", string sort = "")
        {
            List<Cottage> cottages = await (from cot in _context.Cottages
                                      where cot.IsLogicalDelete == false
                                      select cot).ToListAsync();
            return View(cottages);
        }

        // GET: Cottages1/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cottage = await _context.Cottages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cottage == null)
            {
                return NotFound();
            }

            return View(cottage);
        }

        // GET: Cottages1/Create
        [Authorize(Roles = "CottageOwner")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cottages1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "CottageOwner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Cottage cottage)
        {
            AppUser user =await _userManager.GetUserAsync(User);
            cottage.OwnerID = user.Id;
            cottage.IsLogicalDelete = false;
            _context.Add(cottage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetMyCottages));
        }

        // GET: Cottages1/Edit/5
        [Authorize(Roles = "CottageOwner")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cottage = await _context.Cottages.FindAsync(id);
            if (cottage == null)
            {
                return NotFound();
            }
            return View(cottage);
        }

        // POST: Cottages1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "CottageOwner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Cottage cottage)
        {
            if (id != cottage.Id)
            {
                return NotFound();
            }

            int numberOfApp = (from app in _context.scheduledAppointments
                                                    where app.EntityID == cottage.Id && app.IsActive == true && app.Start >= DateTime.Now
                                                    select app).Count();

            if(numberOfApp == 0) { 

                var user = await _userManager.GetUserAsync(User);
                cottage.OwnerID = user.Id;

                _context.Update(cottage);
                await _context.SaveChangesAsync();
                
                
                return RedirectToAction(nameof(GetMyCottages));
            }
            else
            {
                return View("Error");
            }

    }

        // GET: Cottages1/Delete/5
        [Authorize(Roles = "CottageOwner")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cottage = await _context.Cottages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cottage == null)
            {
                return NotFound();
            }

            return View(cottage);
        }

        // POST: Cottages1/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "CottageOwner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var cottage = await _context.Cottages.FindAsync(id);

            int numberOfApp = (from app in _context.scheduledAppointments
                               where app.EntityID == cottage.Id && app.IsActive == true && app.Start >= DateTime.Now
                               select app).Count();

            if (numberOfApp == 0)
            {
                cottage.IsLogicalDelete = true;
                _context.Cottages.Update(cottage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetMyCottages));
            }
            else
            {
                return View("Error");
            }
        }

        private bool CottageExists(long id)
        {
            return _context.Cottages.Any(e => e.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> GetAvailableCottages(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            var user = await _userManager.GetUserAsync(User);
            return View(await _cottageService.GetAvailableCottages(user.Id, dateTime, numberOfGuest, numberOfDays, averageScore));
        }

        public async Task<IActionResult> GetMyCottages()
        {
            var user = await _userManager.GetUserAsync(User);

            List<Cottage> cottages = await (from cot in _context.Cottages
                                            where cot.IsLogicalDelete == false && cot.OwnerID == user.Id
                                            select cot).ToListAsync();
            return View(cottages);
        }



    }
}
