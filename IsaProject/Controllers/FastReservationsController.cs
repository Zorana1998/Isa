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
using Microsoft.AspNetCore.Identity.UI.Services;
using IsaProject.Services;
using System.IO;
using Newtonsoft.Json;
using Isa.Areas.Identity;
using IsaProject.Models;

namespace IsaProject.Controllers
{
    public class FastReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IFastReservationService _fastReservationService;

        public FastReservationsController(ApplicationDbContext context, UserManager<AppUser> userManager, IEmailSender emailSender, IFastReservationService fastReservationService)
        {
            _context = context;
            _userManager = userManager;
            using (StreamReader r = new StreamReader("./Areas/Identity/emailCredentials.json"))
            {
                string json = r.ReadToEnd();
                _emailSender = JsonConvert.DeserializeObject<EmailSender>(json);
            }
            _fastReservationService = fastReservationService;
        }

        // GET: FastReservations
        public async Task<IActionResult> Index()
        {
            return View(await _context.FastReservations.ToListAsync());
        }

        // GET: FastReservations/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fastReservation = await _context.FastReservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fastReservation == null)
            {
                return NotFound();
            }

            return View(fastReservation);
        }

        // GET: FastReservations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FastReservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NewPrice,Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,Price,isScheduled")] FastReservation fastReservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fastReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fastReservation);
        }

        // GET: FastReservations/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fastReservation = await _context.FastReservations.FindAsync(id);
            if (fastReservation == null)
            {
                return NotFound();
            }
            return View(fastReservation);
        }

        // POST: FastReservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("NewPrice,Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,Price,isScheduled")] FastReservation fastReservation)
        {
            if (id != fastReservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fastReservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FastReservationExists(fastReservation.Id))
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
            return View(fastReservation);
        }

        // GET: FastReservations/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fastReservation = await _context.FastReservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fastReservation == null)
            {
                return NotFound();
            }

            return View(fastReservation);
        }

        // POST: FastReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var fastReservation = await _context.FastReservations.FindAsync(id);
            _context.FastReservations.Remove(fastReservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FastReservationExists(long id)
        {
            return _context.FastReservations.Any(e => e.Id == id);
        }

        public async Task<IActionResult> TakeAppointment(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            var fastReservation = await _context.FastReservations.FindAsync(id);

            ScheduledAppointment scheduledAppointment = new ScheduledAppointment();
            scheduledAppointment.UserID = user.Id;
            scheduledAppointment.EntityID = fastReservation.EntityID;
            scheduledAppointment.Start = fastReservation.Start;
            scheduledAppointment.Duration = fastReservation.DurationDays;
            scheduledAppointment.NumberOfPeople = fastReservation.MaxNumberOfPeople;
            scheduledAppointment.Price = fastReservation.Price;
            scheduledAppointment.IsActive = true;

            _context.FastReservations.Remove(fastReservation);
            _context.scheduledAppointments.Add(scheduledAppointment);
            _context.SaveChanges();

            await _emailSender.SendEmailAsync(user.Email, "Scheduled Appointment",
                $"Scheduled Appointment for {user.FirstName} at {fastReservation.Start}");

            return View();
        }


        // GET: FastReservations
        public async Task<IActionResult> GetFree()
        {
            var fastRes = await (from fast in _context.FastReservations
                                         select fast).ToListAsync();
            return View(fastRes);
        }

        



    }
}
