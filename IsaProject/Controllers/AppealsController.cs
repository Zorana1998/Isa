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
using IsaProject.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json;
using System.IO;
using IsaProject.Areas.Identity;

namespace IsaProject.Controllers
{
    public class AppealsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;

        public AppealsController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            using StreamReader r = new StreamReader("./Areas/Identity/emailCredentials.json");
            var json = r.ReadToEnd();
            _emailSender = JsonConvert.DeserializeObject<EmailSender>(json);
        }

        // GET: Appeals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appeal.ToListAsync());
        }

        // GET: Appeals/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appeal = await _context.Appeal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appeal == null)
            {
                return NotFound();
            }

            return View(appeal);
        }

        // GET: Appeals/Create
        public IActionResult Create(long? Id)
        {
            Appeal appeal = new Appeal();
            appeal.EntityID = Id;
            return View(appeal);
        }

        // POST: Appeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(long Id, [Bind("Id,UserApprovalSendID,EntityID,UserApprovalReceivedID,Content")] Appeal appeal)
        {
            
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var appealNew = new Appeal();
                appealNew.EntityID = Id;
                appealNew.Content = appeal.Content;
                appealNew.UserApprovalSendID = user.Id;
                appealNew.IsAnswered = false;

                _context.Add(appealNew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetPossibleAppealForEntities));
            }
            return View(appeal);
        }



        // GET: Appeals/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appeal = await _context.Appeal.FindAsync(id);
            if (appeal == null)
            {
                return NotFound();
            }
            return View(appeal);
        }

        // POST: Appeals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ContentAnswer")] Appeal appeal)
        {

            if (id != appeal.Id)
            {
                return NotFound();
            }

            Appeal appealUpdate = _context.Appeal.Find(id);
            appealUpdate.IsAnswered = true;
            appealUpdate.ContentAnswer = appeal.ContentAnswer;


            _context.Appeal.Update(appealUpdate);
            await _context.SaveChangesAsync();

            AppUser appUserSentAppeal = _context.tbAppUsers.Find(appealUpdate.UserApprovalSendID);

            var user = await _userManager.GetUserAsync(User);

            AppUser appUserAnswerAppeal = _context.tbAppUsers.Find(user.Id);



            await _emailSender.SendEmailAsync(appUserAnswerAppeal.Email, "Appeal",
                $"Appeal {appealUpdate.Content}, answer {appealUpdate.ContentAnswer}");

            await _emailSender.SendEmailAsync(appUserSentAppeal.Email, "Appeal",
                $"Appeal {appealUpdate.Content}, answer {appealUpdate.ContentAnswer}");

            return RedirectToAction(nameof(GetUnansweredAppeals));
        }

        // GET: Appeals/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appeal = await _context.Appeal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appeal == null)
            {
                return NotFound();
            }

            return View(appeal);
        }

        // POST: Appeals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var appeal = await _context.Appeal.FindAsync(id);
            _context.Appeal.Remove(appeal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppealExists(long id)
        {
            return _context.Appeal.Any(e => e.Id == id);
        }

        public async Task<IActionResult> GetPossibleAppealForEntities()
        {
            var user = await _userManager.GetUserAsync(User);

            List<long> entityIds = await (from u in _context.scheduledAppointments
                                                             where u.UserID == user.Id && u.Start < System.DateTime.Now && u.IsActive == true
                                                             select u.EntityID).ToListAsync();

            List<Entity> entities = new();

            foreach(long id in entityIds)
            {
                Entity entity = _context.Entities.Find(id);

                if (!entities.Contains(entity))
                {
                    entities.Add(entity);
                }

            }

            return View(entities);
        }

        public async Task<IActionResult> GetPossibleAppealForUsers()
        {
            var user = await _userManager.GetUserAsync(User);

            List<string> usersIds = await (from u in _context.scheduledAppointments
                                          where u.UserID == user.Id && u.Start < System.DateTime.Now && u.IsActive == true
                                          select u.UserID).ToListAsync();

            List<AppUser> appUsers = new();

            foreach (string id in usersIds)
            {
                AppUser appUser = _context.tbAppUsers.Find(id);

                if (!appUsers.Contains(appUser))
                {
                    appUsers.Add(appUser);
                }

            }

            return View(appUsers);
        }


        // GET: Appeals/Create
        public IActionResult CreateUser(string? Id)
        {
            Appeal appeal = new Appeal();
            appeal.UserApprovalReceivedID = Id;
            return View(appeal);
        }

        // POST: Appeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(string Id, [Bind("Id,UserApprovalSendID,EntityID,UserApprovalReceivedID,Content")] Appeal appeal)
        {

            
                var user = await _userManager.GetUserAsync(User);
                var appealNew = new Appeal();
                appealNew.UserApprovalReceivedID = Id;
                appealNew.Content = appeal.Content;
                appealNew.UserApprovalSendID = user.Id;
                appealNew.IsAnswered = false;

                _context.Add(appealNew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetPossibleAppealForUsers));
            
            
        }


        public async Task<IActionResult> GetUnansweredAppeals()
        {
            List<Appeal> appeals = await (from u in _context.Appeal
                                         where u.IsAnswered == false
                                         select u).ToListAsync();

            return View(appeals);
        }



        



    }
}
