using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Services;
using IsaProject.Models;

namespace IsaProject.Controllers
{
    public class ShipsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IShipService _shipService;

        public ShipsController(ApplicationDbContext context, IShipService shipService)
        {
            _context = context;
            _shipService = shipService;
        }

        // GET: Ships1
        public async Task<IActionResult> Index(string searchString = "", string filter = "", string sort = "")
        {
            return View(await _shipService.GetAllFiltered(searchString, filter, sort));
        }

        // GET: Ships1/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ships
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ship == null)
            {
                return NotFound();
            }

            return View(ship);
        }

        // GET: Ships1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ships1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Length,EngineNumber,EnginePower,MaxSpeed,Capacity,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Ship ship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ship);
        }

        // GET: Ships1/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ships.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }
            return View(ship);
        }

        // POST: Ships1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Type,Length,EngineNumber,EnginePower,MaxSpeed,Capacity,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Ship ship)
        {
            if (id != ship.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipExists(ship.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ship);
        }

        // GET: Ships1/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ships
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ship == null)
            {
                return NotFound();
            }

            return View(ship);
        }

        // POST: Ships1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ship = await _context.Ships.FindAsync(id);
            _context.Ships.Remove(ship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipExists(long id)
        {
            return _context.Ships.Any(e => e.Id == id);
        }
    }
}
