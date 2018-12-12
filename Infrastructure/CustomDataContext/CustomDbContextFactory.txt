using Infrastructure.DbContextBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CustomDataContext
{
    public class CustomDbContextFactory : DbContextFactoryBase<CustomDbContext>
    {
        protected override CustomDbContext CreateNewInstance(DbContextOptions<CustomDbContext> options)
        {
            //throw new NotImplementedException();
            return new CustomDbContext(options);
        }
    }
}
