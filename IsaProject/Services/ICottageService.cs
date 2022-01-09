using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface ICottageService
    {
        public Task<List<AppointmentDTO>> GetAvailableCottages(DateTime dateTime, int numberOfGuest, int numberOfDays, int averageScore);
        public Task<List<Cottage>> GetAllFiltered(string searchString, string filter, string sort);

    }
}
