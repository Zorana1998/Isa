using IsaProject.Models;
using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IShipService
    {
        public Task<List<Ship>> GetAllFiltered(string searchString, string filter, string sort);
        public Task<List<AppointmentDTO>> GetAvailableShips(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore, string id);
    }
}
