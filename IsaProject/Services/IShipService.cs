using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
using IsaProject.Models.Entities.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IShipService
    {
        public Task<List<Ship>> GetAllFiltered(string searchString, string filter, string sort);
        public Task<List<ShipAppointmentDTO>> GetAvailableShips(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore);
    }
}
