using ApplicationCore.Entity.SystemModel;
using ApplicationCore.Interface;
using ApplicationCore.RepositoryInterface;
using ApplicationCore.Specifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly IRepositoryAsync<T_MENU_MASTER> _menuMasterRepositoryAsync;
        private readonly IRepository<T_MENU_MASTER> _menuMasterRepository;

        public MenuMasterService(IRepositoryAsync<T_MENU_MASTER> menuMasterRepositoryAsync, IRepository<T_MENU_MASTER> menuMasterRepository)
        {
            _menuMasterRepositoryAsync = menuMasterRepositoryAsync;
            _menuMasterRepository = menuMasterRepository;
        }

        public IEnumerable<T_MENU_MASTER> GetMenuMaster()
        {
            return _menuMasterRepository.ListAll();
        }

        public Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_MENU_MASTER> GetMenuMasterByUserRole(string CODE_TYPE)
        {
            var result = _menuMasterRepository.List(new MenuWithItemsSpecification(CODE_TYPE));
            return result;
        }

        public Task<IEnumerable<T_MENU_MASTER>> GetMenuMasterByUserRoleAsync(string CODE_TYPE)
        {
            throw new NotImplementedException();
        }
    }
}
