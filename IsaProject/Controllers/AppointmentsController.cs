using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaProject.Data;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using IsaProject.Services;
using IsaProject.Models;
using System.IO;
using Newtonsoft.Json;
using Isa.Areas.Identity;

namespace IsaProject.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(ApplicationDbContext context, UserManager<AppUser> userManager, IEmailSender emailSender, IAppointmentService appointmentService)
        {
            _context = context;
            _userManager = userManager;
            using (StreamReader r = new StreamReader("./Areas/Identity/emailCredentials.json"))
            {
                string json = r.ReadToEnd();
                _emailSender = JsonConvert.DeserializeObject<EmailSender>(json);
            }
            _appointmentService = appointmentService;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appointments.ToListAsync());
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,Price,isScheduled")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,Price,isScheduled")] Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
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
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(long id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }

        public async Task<IActionResult> TakeAppointment(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            var app1 = await (from appdb in _context.cottageAppointmentDTOs
                             where appdb.CustomerId == user.Id
                             select appdb).ToListAsync();

            var app = app1[app1.Count - 1]; ;

            var appointment = await _context.Appointments.FindAsync(id);


            //Appointment for schedule
            Appointment appointmentNew = new Appointment();
            appointmentNew.isScheduled = true;
            appointmentNew.MaxNumberOfPeople = app.NumberOfGuest;
            appointmentNew.OwnerID = appointment.OwnerID;
            appointmentNew.Price = appointment.Price;
            appointmentNew.Start = app.StartDate;
            appointmentNew.DurationDays = app.Duration;
            appointmentNew.UserID = user.Id;
            appointmentNew.Tags = appointment.Tags;

            _context.Appointments.Add(appointmentNew);
            await _context.SaveChangesAsync();

            //NewAppointments because appointment take
            if (appointment.Start.AddDays(appointment.DurationDays) == appointmentNew.Start.AddDays(appointmentNew.DurationDays)){
                Appointment appointmentFreeSchedule = new Appointment();
                appointmentFreeSchedule.isScheduled = false;
                appointmentFreeSchedule.MaxNumberOfPeople = appointment.MaxNumberOfPeople;
                appointmentFreeSchedule.OwnerID = appointment.OwnerID;
                appointmentFreeSchedule.Price = appointment.Price;
                appointmentFreeSchedule.Start = appointment.Start;
                appointmentFreeSchedule.DurationDays = (int)((app.StartDate)-(appointment.Start)).TotalDays;
                appointmentFreeSchedule.UserID = null;
                appointmentFreeSchedule.Tags = appointment.Tags;
                _context.Appointments.Add(appointmentFreeSchedule);
                await _context.SaveChangesAsync();
            }

            if (appointment.Start.AddDays(appointment.DurationDays) != appointmentNew.Start.AddDays(appointmentNew.DurationDays))
            {
                Appointment appointmentFreeScheduleBefore = new Appointment();
                appointmentFreeScheduleBefore.isScheduled = false;
                appointmentFreeScheduleBefore.MaxNumberOfPeople = appointment.MaxNumberOfPeople;
                appointmentFreeScheduleBefore.OwnerID = appointment.OwnerID;
                appointmentFreeScheduleBefore.Price = appointment.Price;
                appointmentFreeScheduleBefore.Start = appointment.Start;
                appointmentFreeScheduleBefore.DurationDays = (int)((app.StartDate) - (appointment.Start)).TotalDays;
                appointmentFreeScheduleBefore.UserID = null;
                appointmentFreeScheduleBefore.Tags = appointment.Tags;
                _context.Appointments.Add(appointmentFreeScheduleBefore);
                await _context.SaveChangesAsync();

                Appointment appointmentFreeScheduleEnd = new Appointment();
                appointmentFreeScheduleEnd.isScheduled = false;
                appointmentFreeScheduleEnd.MaxNumberOfPeople = appointment.MaxNumberOfPeople;
                appointmentFreeScheduleEnd.OwnerID = appointment.OwnerID;
                appointmentFreeScheduleEnd.Price = appointment.Price;
                appointmentFreeScheduleEnd.Start = appointment.Start.AddDays(app.Duration);
                appointmentFreeScheduleEnd.DurationDays = appointment.DurationDays - app.Duration - appointmentFreeScheduleBefore.DurationDays;
                appointmentFreeScheduleEnd.UserID = null;
                appointmentFreeScheduleEnd.Tags = appointment.Tags;
                _context.Appointments.Add(appointmentFreeScheduleEnd);
                await _context.SaveChangesAsync();
            }

            
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();



            /*try
            {
                await (appointment);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_appointmentService.Exists(appointment.Id))
                {
                    return NotFound();
                }
                else
                {
                    return View("ConcurrencyError", "Home");
                }
            }*/
            await _emailSender.SendEmailAsync(user.Email, "Scheduled Appointment",
                $"Scheduled Appointment for {user.FirstName} at {appointment.Start}");

            return View();
        }


        public async Task<IActionResult> AddTags(long id)
        {
            var Appointment = await _context.Appointments.FindAsync(id);

            List<Tag> tagChoosen = await (from tag in _context.Tags
                                    join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                    join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                    where app.Id == id
                                    select tag).ToListAsync();

            List<Tag> tags = new List<Tag>();
            List<Tag> allTags = await _context.Tags.ToListAsync();

            foreach (var tag in allTags)
            {
                if (!tagChoosen.Contains(tag))
                {
                    tags.Add(tag);
                }
            }


            return View(tags);
        }

        [HttpPost]
        public async Task<IActionResult> AddTags(long id, long appointmentId)
        {
            var Tag = await _context.Tags.FindAsync(id);

            var Appointment = await _context.Appointments.FindAsync(appointmentId);

            var appointmentTag = new AppointmentTag();

            appointmentTag.TagId = id;

            appointmentTag.AppointmentID = appointmentId;

            _context.AppointmentTag.Add(appointmentTag);
            await _context.SaveChangesAsync();

            List<Tag> tagChoosen = await (from tag in _context.Tags
                                          join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                          join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                          where app.Id == id
                                          select tag).ToListAsync();

            List<Tag> tags = new List<Tag>();
            List<Tag> allTags = await _context.Tags.ToListAsync();

            foreach (var tag in allTags)
            {
                if (!tagChoosen.Contains(tag))
                {
                    tags.Add(tag);
                }
            }

            return RedirectToAction(nameof(AddTags));

        }

        public async Task<IActionResult> AddTagsUser(long id)
        {
            var Appointment = await _context.Appointments.FindAsync(id);

            List<Tag> tagChoosen = await (from tag in _context.Tags
                                          join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                          join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                          where app.Id == id && app.UserID == null
                                          select tag).ToListAsync();

            


            return View(tagChoosen);
        }

        [HttpPost]
        public async Task<IActionResult> AddTagsUser(long id, long appointmentId)
        {
            var Tag = await _context.Tags.FindAsync(id);

            var Appointment = await _context.Appointments.FindAsync(appointmentId);

            var appointmentTag = new AppointmentTag();

            appointmentTag.TagId = id;

            appointmentTag.AppointmentID = appointmentId;

            var appointmentTags = await _context.AppointmentTag
                .FirstOrDefaultAsync(m => m.AppointmentID == Appointment.Id && m.TagId == Tag.Id);
            appointmentTags.ChoosenByUser = true;

            _context.AppointmentTag.Update(appointmentTags);

            await _context.SaveChangesAsync();

            /*List<Tag> tagChoosen = await (from tag in _context.Tags
                                          join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                          join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                          where app.Id == id && app.UserID == null
                                          select tag).ToListAsync();

            List<Tag> tags = new List<Tag>();
            List<Tag> allTags = await _context.Tags.ToListAsync();

            foreach (var tag in allTags)
            {
                if (!tagChoosen.Contains(tag))
                {
                    tags.Add(tag);
                }
            }*/

            return RedirectToAction(nameof(AddTags));

        }

    }
}
