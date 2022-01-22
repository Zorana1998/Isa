using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Models.Entities.Adventure;
using IsaProject.Services;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using IsaProject.Models.DTO;
using IsaProject.Models;
using IsaProject.Models.Entities;

namespace IsaProject.Controllers
{
    public class AdventuresController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IAdventureService _adventureService;

        private readonly UserManager<AppUser> _userManager;

        public AdventuresController(ApplicationDbContext context, IAdventureService adventureService, UserManager<AppUser> userManager)
        {
            _context = context;
            _adventureService = adventureService;
            _userManager = userManager;
        }

        // GET: Adventures
        public async Task<IActionResult> Index(string searchString = "", string filter = "", string sort = "")
        {
            return View(await (from adv in _context.Adventure select adv).ToListAsync());
        }

        // GET: Adventures/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adventure = await _context.Adventure
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adventure == null)
            {
                return NotFound();
            }

            return View(adventure);
        }

        // GET: Adventures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adventures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstructorDescription,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Adventure adventure)
        {
            
                AppUser user = await _userManager.GetUserAsync(User);
                adventure.OwnerID = user.Id;
                adventure.IsLogicalDelete = false;
                _context.Adventure.Add(adventure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetMyAdventures));
            
           
        }

        // GET: Adventures/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adventure = await _context.Adventure.FindAsync(id);
            if (adventure == null)
            {
                return NotFound();
            }
            return View(adventure);
        }

        // POST: Adventures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("InstructorDescription,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Adventure adventure)
        {
            if (id != adventure.Id)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            adventure.OwnerID = user.Id;

            _context.Update(adventure);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(GetMyAdventures));
        }

        // GET: Adventures/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adventure = await _context.Adventure
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adventure == null)
            {
                return NotFound();
            }

            return View(adventure);
        }

        // POST: Adventures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ship = await _context.ShipBooking.FindAsync(id);
            ship.IsLogicalDelete = true;
            _context.ShipBooking.Update(ship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetMyAdventures));
        }

        private bool AdventureExists(long id)
        {
            return _context.Adventure.Any(e => e.Id == id);
        }

        public IActionResult GetAvailableAdventure()
        {
            return View(new List<AppointmentDTO>());
        }


        [HttpPost]
        public async Task<IActionResult> GetAvailableAdventures(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            var user = await _userManager.GetUserAsync(User);
            return View(await _adventureService.GetAvailableAdventures(user.Id, dateTime, numberOfGuest, numberOfDays, averageScore));
        }

        public async Task<IActionResult> GetMyAdventures()
        {
            var user = await _userManager.GetUserAsync(User);

            List<Adventure> adventures = await (from cot in _context.Adventure
                                                    where cot.IsLogicalDelete == false && cot.OwnerID == user.Id
                                                    select cot).ToListAsync();
            return View(adventures);
        }

    }

        
}
