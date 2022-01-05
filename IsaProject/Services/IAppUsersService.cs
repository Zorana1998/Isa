using IsaProject.Models.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsaProject.Services
{
    public interface IAppUsersService
    {
        public Task<string> GetUserRole(string id);
        public Task<List<AppUser>> GetByList(List<string> idList);
        public Task<AppUser> GetById(string id);
        public Task<int> Update(AppUser user);
        bool Exists(string id);
        public void Create(AppUser user);
    }
}
