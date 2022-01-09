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

namespace IsaProject.Services
{
    public class CottageService : ICottageService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CottageService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<AppointmentDTO>> GetAvailableCottages(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore)
        {
            List<AppointmentDTO> cottages;
            cottages = await (from cottage in _context.Cottages
                                            join cottageAppointment in _context.Appointments on cottage.Id equals cottageAppointment.EntityID
                                            where cottage.AverageScore > averageScore
                                            && cottageAppointment.MaxNumberOfPeople > numberOfGuest
                                            && cottageAppointment.Start <= dateTime
                                            && cottageAppointment.Start.AddDays(cottageAppointment.DurationDays) > dateTime.AddDays(numberOfDays)
                                            && cottageAppointment.UserID == null
                                            select new AppointmentDTO(cottageAppointment.Id,cottage.Name,cottage.Address,cottage.Country,cottage.City,cottage.AverageScore, cottage.Rules, cottageAppointment.Price, dateTime, numberOfDays)).ToListAsync();

            return cottages;
        }

        public async Task<List<Cottage>> GetAllFiltered(string searchString, string filter, string sort)
        {

            var cottages = new List<Cottage>();
            if (sort != null)
            {
                if (sort == "Score")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.AverageScore).ToListAsync();
                }
                else if (sort == "Name")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Name).ToListAsync();
                }
                else if (sort == "Adress")
                {
                    cottages = await _context.Cottages.OrderBy(x => x.Address).ToListAsync();
                }
                else
                {
                    cottages = await _context.Cottages.ToListAsync();
                }
            }
            else
            {
                cottages = await _context.Cottages.ToListAsync();
            }

            List<Cottage> filteredCottages = new List<Cottage>();

            if (string.IsNullOrEmpty(searchString))
            {
                filteredCottages = cottages;
            }
            else
            {
                foreach (var cottage in cottages)
                {
                    var json = JsonConvert.SerializeObject(cottage);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (dictionary[filter] != null && dictionary[filter].ToUpper().Contains(searchString.ToUpper()))
                    {
                        filteredCottages.Add(cottage);
                    }
                }
            }

            return filteredCottages;
        }

        
    }


    
}