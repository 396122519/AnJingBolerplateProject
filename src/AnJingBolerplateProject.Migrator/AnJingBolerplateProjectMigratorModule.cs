using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AnJingBolerplateProject.Configuration;
using AnJingBolerplateProject.EntityFrameworkCore;
using AnJingBolerplateProject.Migrator.DependencyInjection;

namespace AnJingBolerplateProject.Migrator
{
    [DependsOn(typeof(AnJingBolerplateProjectEntityFrameworkModule))]
    public class AnJingBolerplateProjectMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AnJingBolerplateProjectMigratorModule(AnJingBolerplateProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AnJingBolerplateProjectMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AnJingBolerplateProjectConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AnJingBolerplateProjectMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
