using IsaProject.Models;
using IsaProject.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IAppointmentService
    {
        public Task<int> Update(Appointment appointment);
        public bool Exists(long id);

        public Task<List<ScheduledAppointment>> GetMyReservation(string id);
        public Task<List<ScheduledAppointment>> GetMyHistoryReservationCottages(string id);
        public Task<List<ScheduledAppointment>> GetMyHistoryReservationAdventures(string id);
        public Task<List<ScheduledAppointment>> GetMyHistoryReservationShips(string id);
        public Task<List<ScheduledAppointment>> GetMyHistoryReservationOwner(string id);
        public Task<List<Appointment>> GetMyAppointmentOwner(string id);
        public Appointment GetById(long id);
    }

}
