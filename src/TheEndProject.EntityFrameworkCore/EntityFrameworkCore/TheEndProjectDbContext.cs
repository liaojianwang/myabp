using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TheEndProject.Authorization.Roles;
using TheEndProject.Authorization.Users;
using TheEndProject.MultiTenancy;

namespace TheEndProject.EntityFrameworkCore
{
    public class TheEndProjectDbContext : AbpZeroDbContext<Tenant, Role, User, TheEndProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TheEndProjectDbContext(DbContextOptions<TheEndProjectDbContext> options)
            : base(options)
        {
        }
    }
}
