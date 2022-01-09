using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Models.Entities;

namespace IsaProject.Controllers
{
    public class AppointmentTagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentTagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AppointmentTags
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppointmentTag.ToListAsync());
        }

        // GET: AppointmentTags/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentTag = await _context.AppointmentTag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointmentTag == null)
            {
                return NotFound();
            }

            return View(appointmentTag);
        }

        // GET: AppointmentTags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppointmentTags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AppointmentID,TagId")] AppointmentTag appointmentTag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointmentTag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointmentTag);
        }

        // GET: AppointmentTags/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentTag = await _context.AppointmentTag.FindAsync(id);
            if (appointmentTag == null)
            {
                return NotFound();
            }
            return View(appointmentTag);
        }

        // POST: AppointmentTags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,AppointmentID,TagId")] AppointmentTag appointmentTag)
        {
            if (id != appointmentTag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointmentTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentTagExists(appointmentTag.Id))
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
            return View(appointmentTag);
        }

        // GET: AppointmentTags/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentTag = await _context.AppointmentTag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointmentTag == null)
            {
                return NotFound();
            }

            return View(appointmentTag);
        }

        // POST: AppointmentTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var appointmentTag = await _context.AppointmentTag.FindAsync(id);
            _context.AppointmentTag.Remove(appointmentTag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentTagExists(long id)
        {
            return _context.AppointmentTag.Any(e => e.Id == id);
        }
    }
}
