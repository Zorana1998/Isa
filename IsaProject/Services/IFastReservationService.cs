using IsaProject.Models.Entities;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IFastReservationService
    {
        public Task<int> Update(FastReservation fastReservation);
        public bool Exists(long id);
    }
}
