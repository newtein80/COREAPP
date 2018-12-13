using ApplicationCore.Entity.SystemModel;
using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterface
{
    public interface IMenuMasterRepository : IRepository<T_MENU_MASTER>, IRepositoryAsync<T_MENU_MASTER>
    {
        Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterAsync();
        Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterByUserRoleAsync(string USER_ROLE);

        IEnumerable<T_MENU_MASTER> GetMenuMaster();
        IEnumerable<T_MENU_MASTER> GetMenuMasterByUserRole(string USER_ROLE);
    }
}
