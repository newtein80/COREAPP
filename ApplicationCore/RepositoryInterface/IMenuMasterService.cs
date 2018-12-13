using ApplicationCore.Entity.SystemModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterface
{
    public interface IMenuMasterService
    {
        Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterAsync();
        Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterByUserRoleAsync(string CODE_TYPE);

        IEnumerable<T_MENU_MASTER> GetMenuMaster();
        IEnumerable<T_MENU_MASTER> GetMenuMasterByUserRole(string CODE_TYPE);
    }
}
