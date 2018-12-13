using ApplicationCore.Entity.SystemModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class MenuWithItemsSpecification : BaseSpecification<T_MENU_MASTER>
    {
        public MenuWithItemsSpecification(string user_role)
            : base(b => b.USER_ROLL == user_role)
        {
            
        }
    }
}
