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

namespace IsaProject.Controllers
{
    public class CottagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICottageService _cottageService;

        public CottagesController(ApplicationDbContext context, ICottageService cottageService)
        {
            _context = context;
            _cottageService = cottageService;
        }

        // GET: Cottages1
        public async Task<IActionResult> Index(string searchString = "", string filter = "", string sort = "")
        {
            return View(await _cottageService.GetAllFiltered(searchString, filter, sort));
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cottages1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Cottage cottage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cottage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cottage);
        }

        // GET: Cottages1/Edit/5
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] Cottage cottage)
        {
            if (id != cottage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cottage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CottageExists(cottage.Id))
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
            return View(cottage);
        }

        // GET: Cottages1/Delete/5
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var cottage = await _context.Cottages.FindAsync(id);
            _context.Cottages.Remove(cottage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CottageExists(long id)
        {
            return _context.Cottages.Any(e => e.Id == id);
        }

        public IActionResult GetAvailableCottages()
        {
            return View(new List<Cottage>());
        }
        [HttpPost]
        public async Task<IActionResult> GetAvailableCottages(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            return View(await _cottageService.GetAvailableCottages(dateTime, numberOfGuest, numberOfDays, averageScore));
        }

    }
}
