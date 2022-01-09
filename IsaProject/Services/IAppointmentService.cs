using IsaProject.Models.Entities;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IAppointmentService
    {
        public Task<int> Update(Appointment appointment);
        public bool Exists(long id);
    }
}
