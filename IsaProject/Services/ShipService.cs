using Microsoft.AspNetCore.Identity;
using IsaProject.Data;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IsaProject.Models.Entities;
using IsaProject.Models.DTO;
using Newtonsoft.Json;
using IsaProject.Models.Entities.Users;

namespace IsaProject.Services
{
    public class ShipService : IShipService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ShipService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Ship>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var ships = new List<Ship>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    ships = await _context.Ships.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    ships = await _context.Ships.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    ships = await _context.Ships.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    ships = await _context.Ships.ToListAsync();
                }
            }
            else
            {
                ships = await _context.Ships.ToListAsync();
            }

            List<Ship> filteredShips = new List<Ship>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredShips = ships;
            }
            else
            {
                foreach (var ship in ships)
                {
                    var json = JsonConvert.SerializeObject(ship);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredShips.Add(ship);
                    }
                }
            }

            return filteredShips;
        }

        public async Task<List<ShipAppointmentDTO>> GetAvailableShips(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            List<ShipAppointmentDTO> ships;
            ships = await (from ship in _context.Ships
                           join shipAppointment in _context.Appointments on ship.Id equals shipAppointment.EntityID
                           where ship.AverageScore > averageScore
                           && shipAppointment.MaxNumberOfPeople > numberOfGuest
                           && shipAppointment.Start <= dateTime
                           && shipAppointment.Start.AddDays(shipAppointment.DurationDays) > dateTime.AddDays(numberOfDays)
                           select new ShipAppointmentDTO(shipAppointment.Id, ship.Name, ship.Address, ship.Country, ship.City, ship.AverageScore, ship.Rules, shipAppointment.Price, shipAppointment.Start, shipAppointment.DurationDays)).ToListAsync();

            return ships;
        }
    }

    
}
