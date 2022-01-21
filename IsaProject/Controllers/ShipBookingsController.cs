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
using IsaProject.Services;
using IsaProject.Models.DTO;

namespace IsaProject.Controllers
{
    public class ShipBookingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IShipBookingService _shipService;

        public ShipBookingsController(ApplicationDbContext context, UserManager<AppUser> userManager, IShipBookingService shipService)
        {
            _context = context;
            _userManager = userManager;
            _shipService = shipService;
        }

        // GET: ShipBookings
        public async Task<IActionResult> Index(string searchString = "", string filter = "", string sort = "")
        {
            return View(await _shipService.GetAllFiltered(searchString, filter, sort));
        }

        // GET: ShipBookings/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipBooking = await _context.ShipBooking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipBooking == null)
            {
                return NotFound();
            }

            return View(shipBooking);
        }

        // GET: ShipBookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShipBookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Length,EngineNumber,EnginePower,MaxSpeed,Capacity,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] ShipBooking shipBooking)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.GetUserAsync(User);
                shipBooking.OwnerID = user.Id;
                shipBooking.IsLogicalDelete = false;
                _context.Add(shipBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetMyShips));
            }
            return View(shipBooking);
        }

        // GET: ShipBookings/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipBooking = await _context.ShipBooking.FindAsync(id);
            if (shipBooking == null)
            {
                return NotFound();
            }
            return View(shipBooking);
        }

        // POST: ShipBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Type,Length,EngineNumber,EnginePower,MaxSpeed,Capacity,FishingEquipment,Id,Name,Address,Country,City,PromotionalDescription,AverageScore,Rules")] ShipBooking shipBooking)
        {
            if (id != shipBooking.Id)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            shipBooking.OwnerID = user.Id;

            _context.Update(shipBooking);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(GetMyShips));
        }

        // GET: ShipBookings/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipBooking = await _context.ShipBooking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipBooking == null)
            {
                return NotFound();
            }

            return View(shipBooking);
        }

        // POST: ShipBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ship = await _context.ShipBooking.FindAsync(id);
            ship.IsLogicalDelete = true;
            _context.ShipBooking.Update(ship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetMyShips));
        }

        private bool ShipBookingExists(long id)
        {
            return _context.ShipBooking.Any(e => e.Id == id);
        }

        public async Task<IActionResult> GetAvailableShips(string searchString = "", string filter = "", string sort = "")
        {
            return View(new List<AppointmentDTO>());
        }

        [HttpPost]
        public async Task<IActionResult> GetAvailableShips(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            var user = await _userManager.GetUserAsync(User);
            return View(await _shipService.GetAvailableShips(dateTime, numberOfGuest, numberOfDays, averageScore,user.Id));
        }

        public async Task<IActionResult> GetMyShips()
        {
            var user = await _userManager.GetUserAsync(User);
            
            List<ShipBooking> shipBookings = (from cot in _context.ShipBooking
                                                    where cot.IsLogicalDelete == false && cot.OwnerID == user.Id
                                                    select cot).ToList();
            return View(shipBookings);
        }
    }
}
