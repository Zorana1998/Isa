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
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);

            List<Entity> entities = (from u in _context.Entities
                                     where u.CottageOwnerID == user.Id && u.IsLogicalDelete == false
                                     select u).ToList();
            ViewData["GetMyEntities"] = entities;
            return View();
        }

        // POST: FastReservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NewPrice,Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,isScheduled")] FastReservation fastReservation)
        {
                var user = await _userManager.GetUserAsync(User);

                fastReservation.OwnerID = user.Id;
            
                _context.Add(fastReservation);
            
                await _context.SaveChangesAsync();

                Entity entity = _context.Entities.Find(fastReservation.EntityID);

                List<string> appUserIds = new();

                appUserIds = (from sub in _context.Subscription
                                       join user2 in _context.tbAppUsers on sub.OwnerID equals user2.Id
                                       where sub.EntityID == fastReservation.EntityID
                                       select user.Id).ToList();

                List<AppUser> appUser = await _context.tbAppUsers.Where(e => appUserIds.Contains(e.Id)).ToListAsync();

                foreach(AppUser app in appUser)
                {
                    await _emailSender.SendEmailAsync(app.Email, "Fast reservation",
                    $"Fast reservation for {entity.Name}");
                }


                return RedirectToAction(nameof(GetMyFastReservationOwner));
            
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

           
            _context.scheduledAppointments.Add(scheduledAppointment);
            _context.SaveChanges();

            await _emailSender.SendEmailAsync(user.Email, "Scheduled Appointment",
                $"Scheduled Appointment for {user.FirstName} at {fastReservation.Start}");

            return View();
        }


        // GET: FastReservations
        public async Task<IActionResult> GetFree()
        {
            var user = await _userManager.GetUserAsync(User);

            var fastRes = await (from fast in _context.FastReservations
                                         select fast).ToListAsync();

            //All reserved
            List<ScheduledAppointment> scheduledAppointments = await (from schApp in _context.scheduledAppointments
                                                                      join entity in _context.Entities on schApp.EntityID equals entity.Id
                                                                      where schApp.IsActive == true
                                                                      select schApp).ToListAsync();

            //AllMyReservation
            List<ScheduledAppointment> myUnscheduledAppointments = await (from schApp in _context.scheduledAppointments
                                                                      join entity in _context.Entities on schApp.EntityID equals entity.Id
                                                                      join user2 in _context.tbAppUsers on schApp.UserID equals user2.Id
                                                                      where schApp.IsActive == false
                                                                      select schApp).ToListAsync();


            //FindFast
            List<Appointment> appointments = new List<Appointment>();
            foreach (FastReservation fastReservation in fastRes)
            {
                Appointment appointment = _context.Appointments.Find(fastReservation.Id);
                appointments.Add(appointment);

            }

            List<Appointment> availableAppointments = new List<Appointment>();

            var count = 0;

            foreach(Appointment appointmentCheck in appointments)
            {
                count = 0;
                foreach (ScheduledAppointment scheduledAppointmentCheck in scheduledAppointments)
                {
                    if (appointmentCheck.EntityID == scheduledAppointmentCheck.EntityID && appointmentCheck.Start == scheduledAppointmentCheck.Start && scheduledAppointmentCheck.IsActive == true)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    availableAppointments.Add(appointmentCheck);
                }
                
            }

            List<Appointment> solution = new List<Appointment>();

            foreach (Appointment appointment2 in availableAppointments)
            {
                count = 0;
                foreach (ScheduledAppointment scheduledAppointmentCheck in myUnscheduledAppointments)
                {
                    if (appointment2.EntityID == scheduledAppointmentCheck.EntityID && appointment2.Start == scheduledAppointmentCheck.Start)
                    {
                        count++;
                    }
                }
                if(count == 0)
                {
                    solution.Add(appointment2);
                }
                
            }


            List<FastReservation> fastReservationsFree = new List<FastReservation>();

            foreach(Appointment appointment1 in solution)
            {
                foreach(FastReservation fastReservation in fastRes)
                {
                    if(appointment1.Id == fastReservation.Id)
                    {
                        fastReservationsFree.Add(fastReservation);
                    }
                }
            }
            


            return View(fastReservationsFree);
        }

        public async Task<IActionResult> GetMyFastReservationOwner()
        {
            var user = await _userManager.GetUserAsync(User);

            List<FastReservation> fastReservations = await (from u in _context.FastReservations
                                                    where u.OwnerID == user.Id && u.Start > System.DateTime.Now
                                                    select u).ToListAsync();

            return View(fastReservations);
        }






    }
}
