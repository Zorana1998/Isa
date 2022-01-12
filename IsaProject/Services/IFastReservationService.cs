using IsaProject.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IFastReservationService
    {
        public Task<int> Update(FastReservation fastReservation);
        public bool Exists(long id);

        //public Task<List<FastReservation>> GetMyFastReservation(string id);
    }
}
