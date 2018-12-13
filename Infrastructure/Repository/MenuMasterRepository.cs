using ApplicationCore.Entity.SystemModel;
using ApplicationCore.RepositoryInterface;
using Infrastructure.SystemDataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MenuMasterRepository : EfRepository<T_MENU_MASTER>, IMenuMasterRepository
    {
        public MenuMasterRepository(SystemDbContext systemDbContext) : base(systemDbContext)
        {

        }

        public IEnumerable<T_MENU_MASTER> GetMenuMaster()
        {
            return systemDbContext.T_MENU_MASTER.AsEnumerable();
        }

        public Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_MENU_MASTER> GetMenuMasterByUserRole(string USER_ROLE)
        {
            var result = systemDbContext.T_MENU_MASTER.Where(m => m.USER_ROLL == USER_ROLE).ToList();
            return result;
        }

        public Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterByUserRoleAsync(string USER_ROLE)
        {
            throw new NotImplementedException();
        }
    }
}
