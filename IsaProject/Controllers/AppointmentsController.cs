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
using IsaProject.Models.DTO;
using IsaProject.Areas.Identity;

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
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);

            List<Entity> entities = (from u in _context.Entities
                                     where u.OwnerID == user.Id && u.IsLogicalDelete == false
                                     select u).ToList();
            ViewData["GetMyEntities"] = entities;
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerID,UserID,EntityID,Start,DurationDays,MaxNumberOfPeople,Price,isScheduled")] Appointment appointment)
        {
            var user = await _userManager.GetUserAsync(User);
            appointment.OwnerID = user.Id;
            appointment.NumberOfReservations = 0;
            List<Appointment> appointments = await(from app in _context.Appointments
                                             where app.EntityID == appointment.EntityID
                                             select app).ToListAsync();


            int counter = 0;

            foreach (Appointment appointmentDates in appointments)
            {
                        //stari u sredini
                        if (appointmentDates.Start >= appointment.Start && appointmentDates.Start.AddDays(appointmentDates.DurationDays) <= appointment.Start.AddDays(appointment.DurationDays))
                        {
                            counter++;
                        }

                        //novi u sredini
                        if (appointmentDates.Start <= appointment.Start && appointmentDates.Start.AddDays(appointmentDates.DurationDays) >= appointment.Start.AddDays(appointment.DurationDays))
                        {
                            counter++;
                        }

                        if (appointmentDates.Start <= appointment.Start && appointmentDates.Start.AddDays(appointmentDates.DurationDays) >= appointment.Start)
                        {
                            counter++;
                        }

                        if (appointmentDates.Start >= appointment.Start && appointmentDates.Start <= appointment.Start.AddDays(appointment.DurationDays))
                        {
                            counter++;
                        }
            }

            if(counter == 0)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetMyAppointmentOwner));
            }
            else
            {
                return View("Error");
            }

            
            
            
            
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
                return RedirectToAction(nameof(GetMyAppointmentOwner));
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

            var appointmentDTO = await _context.cottageAppointmentDTOs
                .FirstOrDefaultAsync(m => m.Id == id);

            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(m => m.Id == appointmentDTO.AppointmentId);

            try
            {
                appointment.NumberOfReservations++;
                _context.Appointments.Update(appointment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
                    throw;
                
            }


            

            ScheduledAppointment scheduledAppointment = new ScheduledAppointment();
            scheduledAppointment.UserID = user.Id;
            scheduledAppointment.EntityID = appointment.EntityID;
            scheduledAppointment.Start = appointmentDTO.StartDate;
            scheduledAppointment.Duration = appointmentDTO.Duration;
            scheduledAppointment.NumberOfPeople = appointmentDTO.NumberOfGuest;
            scheduledAppointment.Price = appointmentDTO.Price;
            scheduledAppointment.IsActive = true;
            scheduledAppointment.IsCome = false;

            _context.scheduledAppointments.Add(scheduledAppointment);
            _context.SaveChanges();



            //AddTags
            long appNewId = scheduledAppointment.Id;

            var tagChoosenUser = await (from tag in _context.Tags
                                      join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                      join app in _context.cottageAppointmentDTOs on appTag.AppointmentDTOID equals app.Id
                                      select tag).ToListAsync();

            var tagChoosenOwner = await (from tag in _context.Tags
                                      join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                      join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                      select tag).ToListAsync();

            foreach (Tag tag in tagChoosenUser)
            {
                AppointmentTag appointmentTag = new AppointmentTag(appNewId, appointmentDTO.Id, tag.Id, scheduledAppointment.Id);
                _context.AppointmentTag.Add(appointmentTag);
                _context.SaveChanges();
            }

            _context.SaveChanges();

            await _emailSender.SendEmailAsync(user.Email, "Scheduled Appointment",
                $"Scheduled Appointment for {user.FirstName} at {appointment.Start}");

            return RedirectToAction(nameof(GetMyReservation)); 
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
            
            var appointmentDTO = await _context.cottageAppointmentDTOs.FindAsync(id);

            var appointment = await _context.Appointments.FindAsync(appointmentDTO.AppointmentId);

            List<Tag> tagChoosen = await (from tag in _context.Tags
                                          join appTag in _context.AppointmentTag on tag.Id equals appTag.TagId
                                          join app in _context.Appointments on appTag.AppointmentID equals app.Id
                                          where app.Id == appointment.Id && appTag.AppointmentDTOID ==null
                                          select tag).ToListAsync();


            return View(tagChoosen);
        }

        [HttpPost]
        public async Task<IActionResult> AddTagsUser(long id, long appointmentId)
        {
            var Tag = await _context.Tags.FindAsync(id);

            Console.WriteLine(Tag.Id);

            var appointmentDTO = await _context.cottageAppointmentDTOs.FindAsync(appointmentId);

            Console.WriteLine(appointmentDTO.Id);

            var appointmentTag = new AppointmentTag();

            Console.WriteLine(appointmentDTO.AppointmentId);

            appointmentTag.TagId = id;

            appointmentTag.AppointmentID = appointmentDTO.AppointmentId;

            

            var appointmentTags = await _context.AppointmentTag
                .FirstOrDefaultAsync(m => m.AppointmentID == appointmentDTO.AppointmentId && m.TagId == Tag.Id);

            var appTag = new AppointmentTag(appointmentDTO.AppointmentId, appointmentId, id);
            _context.AppointmentTag.Add(appTag);
            _context.SaveChanges();

            return RedirectToAction(nameof(AddTags));

        }


        public async Task<IActionResult> GetMyReservation()
        {

            var user = await _userManager.GetUserAsync(User);


            return View(await _appointmentService.GetMyReservation(user.Id));
        }

        [HttpPost]
        public async Task<IActionResult> CancelReservation(long id)
        {
            var scheduleAppointment = await _context.scheduledAppointments.FindAsync(id);
            Console.WriteLine(scheduleAppointment.Id);
            scheduleAppointment.IsActive = false;

            _context.scheduledAppointments.Update(scheduleAppointment);
            _context.SaveChanges();

            return View();

        }

        public async Task<IActionResult> GetMyHistoryReservationCottages()
        {

            var user = await _userManager.GetUserAsync(User);


            return View(await _appointmentService.GetMyHistoryReservationCottages(user.Id));
        }

        public async Task<IActionResult> GetMyHistoryReservationAdventures()
        {

            var user = await _userManager.GetUserAsync(User);


            return View(await _appointmentService.GetMyHistoryReservationAdventures(user.Id));
        }

        public async Task<IActionResult> GetMyHistoryReservationShips()
        {

            var user = await _userManager.GetUserAsync(User);


            return View(await _appointmentService.GetMyHistoryReservationShips(user.Id));
        }

        public async Task<IActionResult> GetMyAppointmentOwner()
        {

            var user = await _userManager.GetUserAsync(User);

            return View(await _appointmentService.GetMyAppointmentOwner(user.Id));
        }

        public async Task<IActionResult> GetMyHistoryReservationOwner()
        {

            var user = await _userManager.GetUserAsync(User);


            return View(await _appointmentService.GetMyHistoryReservationOwner(user.Id));
        }

    }
}
