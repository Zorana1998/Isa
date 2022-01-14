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
    public class ProfileDeletesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfileDeletesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProfileDeletes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProfileDelete.ToListAsync());
        }

        // GET: ProfileDeletes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profileDelete = await _context.ProfileDelete
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profileDelete == null)
            {
                return NotFound();
            }

            return View(profileDelete);
        }

        // GET: ProfileDeletes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProfileDeletes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,IsApproved")] ProfileDelete profileDelete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profileDelete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profileDelete);
        }

        // GET: ProfileDeletes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profileDelete = await _context.ProfileDelete.FindAsync(id);
            if (profileDelete == null)
            {
                return NotFound();
            }
            return View(profileDelete);
        }

        // POST: ProfileDeletes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Content,IsApproved")] ProfileDelete profileDelete)
        {
            if (id != profileDelete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profileDelete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileDeleteExists(profileDelete.Id))
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
            return View(profileDelete);
        }

        // GET: ProfileDeletes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profileDelete = await _context.ProfileDelete
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profileDelete == null)
            {
                return NotFound();
            }

            return View(profileDelete);
        }

        // POST: ProfileDeletes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var profileDelete = await _context.ProfileDelete.FindAsync(id);
            _context.ProfileDelete.Remove(profileDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfileDeleteExists(long id)
        {
            return _context.ProfileDelete.Any(e => e.Id == id);
        }
    }
}
