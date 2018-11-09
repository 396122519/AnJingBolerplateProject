using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AnJingBolerplateProject.Authorization;

namespace AnJingBolerplateProject
{
    [DependsOn(
        typeof(AnJingBolerplateProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AnJingBolerplateProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AnJingBolerplateProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AnJingBolerplateProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
