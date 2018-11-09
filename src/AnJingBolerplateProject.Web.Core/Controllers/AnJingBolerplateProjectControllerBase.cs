using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AnJingBolerplateProject.Controllers
{
    public abstract class AnJingBolerplateProjectControllerBase: AbpController
    {
        protected AnJingBolerplateProjectControllerBase()
        {
            LocalizationSourceName = AnJingBolerplateProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
