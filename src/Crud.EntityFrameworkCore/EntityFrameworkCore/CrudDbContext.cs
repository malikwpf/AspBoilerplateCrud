using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Crud.Authorization.Roles;
using Crud.Authorization.Users;
using Crud.MultiTenancy;
using Crud.Products;

namespace Crud.EntityFrameworkCore
{
    public class CrudDbContext : AbpZeroDbContext<Tenant, Role, User, CrudDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Product> Products { get; set; }
        public CrudDbContext(DbContextOptions<CrudDbContext> options)
            : base(options)
        {
        }
    }
}
