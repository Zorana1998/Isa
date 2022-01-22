using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Isa.Models;
using IsaProject.Data;
using Microsoft.AspNetCore.Identity;
using IsaProject.Models.Users;
using IsaProject.Models.Entities;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json;
using System.IO;
using IsaProject.Areas.Identity;

namespace IsaProject.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;

        public RatingsController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            using (StreamReader r = new StreamReader("./Areas/Identity/emailCredentials.json"))
            {
                string json = r.ReadToEnd();
                _emailSender = JsonConvert.DeserializeObject<EmailSender>(json);
            }
        }

        // GET: Ratings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rating.ToListAsync());
        }

        // GET: Ratings/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        public IActionResult Create(long Id)
        {
            Rating rating = new Rating();
            rating.EntityID = Id;
            return View(rating);
        }

        // POST: Ratings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(long Id, [Bind("Id,EntityID,EmployeeID,Score,IsApproved")] Rating rating)
        {
            Rating ratingNew = new();
            
            var user = await _userManager.GetUserAsync(User);
            ratingNew.EntityID = Id;
            ratingNew.Score = rating.Score;
            ratingNew.IsApproved = false;
            ratingNew.User = user;
            _context.Add(ratingNew);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetPossibleRatingsForEntities));
            
            
        }

        // GET: Ratings/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || id < 1)
            {
                return NotFound();
            }

            var rating = await _context.Rating.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,EntityID,EmployeeID,Score,IsApproved")] Rating rating)
        {
            if (id != rating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.Id))
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
            return View(rating);
        }

        // GET: Ratings/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var rating = await _context.Rating.FindAsync(id);
            _context.Rating.Remove(rating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RatingExists(long id)
        {
            return _context.Rating.Any(e => e.Id == id);
        }

        public async Task<IActionResult> GetPossibleRatingsForEntities()
        {
            var user = await _userManager.GetUserAsync(User);

            List<long> entityIds = await (from u in _context.scheduledAppointments
                                          where u.UserID == user.Id && u.Start < System.DateTime.Now && u.IsActive == true
                                          select u.EntityID).ToListAsync();

            List<Entity> entities = new();

            foreach (long id in entityIds)
            {
                Entity entity = _context.Entities.Find(id);

                if (!entities.Contains(entity))
                {
                    entities.Add(entity);
                }

            }

            return View(entities);
        }

        public async Task<IActionResult> GetPossibleRatingsForUsers()
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
        public IActionResult CreateUser(string Id)
        {
            Rating rating = new Rating();
            rating.EmployeeID = Id;
            return View(rating);
        }

        // POST: Appeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(string Id, [Bind("Id,EntityID,EmployeeID,Score,IsApproved")] Rating rating)
        {

            Rating ratingNew = new();

            var user = await _userManager.GetUserAsync(User);
            ratingNew.EmployeeID = Id;
            ratingNew.Score = rating.Score;
            ratingNew.IsApproved = false;
            ratingNew.User = user;
            _context.Add(ratingNew);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetPossibleRatingsForUsers));


        }

        public async Task<IActionResult> GetUnapprovedRatings()
        {
            List<Rating> ratings = await (from u in _context.Rating
                                          where u.IsApproved == false
                                          select u).ToListAsync();

            return View(ratings);
        }


        public async Task<IActionResult> Approved(long id)
        {
            Rating rating = _context.Rating.Find(id);


            try
            {
                if (rating.EntityID == 0)
                {
                    AppUser appUser = rating.User;

                    rating.IsApproved = true;

                    _context.Rating.Update(rating);
                    _context.SaveChanges();

                    List<Rating> ratings = await (from u in _context.Rating
                                                  where u.User == appUser && u.IsApproved == true
                                                  select u).ToListAsync();
                    float newRating = 0;

                    int ratingSum = 0;

                    foreach (Rating r in ratings)
                    {
                        ratingSum += r.Score;
                    }

                    newRating = ratingSum / ratings.Count;

                    appUser.AverageScore = newRating;

                    _context.tbAppUsers.Update(appUser);

                    _context.SaveChanges();

                    await _emailSender.SendEmailAsync(appUser.Email, "New rating",
                    $"Rating entity {rating.EntityID} at {rating.Score}");
                }
                else
                {
                    Entity entity = _context.Entities.Find(rating.EntityID);

                    rating.IsApproved = true;

                    _context.Rating.Update(rating);
                    _context.SaveChanges();

                    List<Rating> ratings = await (from u in _context.Rating
                                                  where u.EntityID == rating.EntityID && u.IsApproved == true
                                                  select u).ToListAsync();

                    float newRating = 0;

                    int ratingSum = 0;

                    foreach (Rating r in ratings)
                    {
                        ratingSum += r.Score;
                    }

                    newRating = ratingSum / ratings.Count;

                    entity.AverageScore = newRating;

                    _context.Entities.Update(entity);

                    _context.SaveChanges();

                    AppUser appUser = (from u in _context.Rating
                                       join user in _context.tbAppUsers on u.EmployeeID equals user.Id
                                       select user).ToList().First();

                    await _emailSender.SendEmailAsync(appUser.Email, "New rating",
                    $"Rating entity {rating.EntityID} at {rating.Score}");
                }





                return RedirectToAction(nameof(GetUnapprovedRatings));
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

    }
}
