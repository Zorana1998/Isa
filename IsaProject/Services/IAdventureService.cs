using IsaProject.Models.DTO;
using IsaProject.Models.Entities.Adventure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IAdventureService
    {
        public Task<List<AppointmentDTO>> GetAvailableAdventures(String id,DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore);
        public Task<List<Adventure>> GetAllFiltered(string searchString, string filter, string sort);
    }
}
