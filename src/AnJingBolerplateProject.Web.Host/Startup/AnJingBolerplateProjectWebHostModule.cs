using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AnJingBolerplateProject.Configuration;

namespace AnJingBolerplateProject.Web.Host.Startup
{
    [DependsOn(
       typeof(AnJingBolerplateProjectWebCoreModule))]
    public class AnJingBolerplateProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AnJingBolerplateProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AnJingBolerplateProjectWebHostModule).GetAssembly());
        }
    }
}
