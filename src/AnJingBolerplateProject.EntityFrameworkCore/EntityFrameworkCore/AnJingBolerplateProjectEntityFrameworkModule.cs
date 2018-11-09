using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AnJingBolerplateProject.EntityFrameworkCore.Seed;

namespace AnJingBolerplateProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(AnJingBolerplateProjectCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AnJingBolerplateProjectEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AnJingBolerplateProjectDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AnJingBolerplateProjectDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AnJingBolerplateProjectDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AnJingBolerplateProjectEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
