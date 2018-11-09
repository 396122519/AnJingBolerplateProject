using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AnJingBolerplateProject.Authorization.Roles;
using AnJingBolerplateProject.Authorization.Users;
using AnJingBolerplateProject.MultiTenancy;

namespace AnJingBolerplateProject.EntityFrameworkCore
{
    public class AnJingBolerplateProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AnJingBolerplateProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AnJingBolerplateProjectDbContext(DbContextOptions<AnJingBolerplateProjectDbContext> options)
            : base(options)
        {
        }
    }
}
