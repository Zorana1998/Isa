using IsaProject.Data;
using IsaProject.Models.DTO;
using IsaProject.Models.Entities.Adventure;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public class AdventureService : IAdventureService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AdventureService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Adventure>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var adventures = new List<Adventure>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    adventures = await _context.Adventure.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    adventures = await _context.Adventure.ToListAsync();
                }
            }
            else
            {
                adventures = await _context.Adventure.ToListAsync();
            }

            List<Adventure> filteredAdventures = new List<Adventure>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredAdventures = adventures;
            }
            else
            {
                foreach (var adventure in adventures)
                {
                    var json = JsonConvert.SerializeObject(adventure);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredAdventures.Add(adventure);
                    }
                }
            }

            return filteredAdventures;
        }

        public async Task<List<AppointmentDTO>> GetAvailableAdventure(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            List<AppointmentDTO> appointmentDTOs;
            appointmentDTOs = await (from adventure in _context.Adventure
                              join adventureAppointment in _context.Appointments on adventure.Id equals adventureAppointment.EntityID
                              where adventure.AverageScore > averageScore
                              && adventureAppointment.MaxNumberOfPeople > numberOfGuest
                              && adventureAppointment.Start <= dateTime
                              && adventureAppointment.Start.AddDays(adventureAppointment.DurationDays) > dateTime.AddDays(numberOfDays)
                              select new AppointmentDTO(adventureAppointment.Id, adventure.Name, adventure.Address, adventure.Country, adventure.City, adventure.AverageScore, adventure.Rules, adventureAppointment.Price, dateTime, numberOfDays)).ToListAsync();

            return appointmentDTOs;
        }

    }
}
