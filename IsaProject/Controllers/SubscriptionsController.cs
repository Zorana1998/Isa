using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using IsaProject.Models.Users;

namespace IsaProject.Controllers
{
    public class SubscriptionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<AppUser> _userManager;

        public SubscriptionsController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Subscriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscription.ToListAsync());
        }

        // GET: Subscriptions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: Subscriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerID,EntityID")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,OwnerID,EntityID")] Subscription subscription)
        {
            if (id != subscription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Id))
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
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subscription = await _context.Subscription.FindAsync(id);

            List<Subscription> subscriptionList= new List<Subscription>();
            subscriptionList = await _context.Subscription
                                          .Where(l => l.EntityID == subscription.Id && l.OwnerID == subscription.OwnerID).ToListAsync();

            foreach(Subscription sub in subscriptionList)
            {
                _context.Subscription.Remove(sub);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(GetMySubscriptions));
        }

        private bool SubscriptionExists(long id)
        {
            return _context.Subscription.Any(e => e.Id == id);
        }

        
        public async Task<IActionResult> Subscribe(long id)
        {
            var user = await _userManager.GetUserAsync(User);
            Subscription subscribe = new()
            {
                EntityID = id,
                OwnerID = user.Id
            };
            _context.Subscription.Add(subscribe);
            await _context.SaveChangesAsync();
            return View();
        }


        public async Task<IActionResult> GetMySubscriptions()
        {
            var user = await _userManager.GetUserAsync(User);

            var subscription = await _context.Subscription
                                          .Where(l => l.OwnerID == user.Id).ToListAsync();

            var subunique = subscription.Select(s => s.EntityID).Distinct();

            List<Subscription> distinctSub = subscription
                                .GroupBy(p => p.EntityID)
                                .Select(g => g.FirstOrDefault())
                                .ToList();


            return View(distinctSub);
        }
    }
}
