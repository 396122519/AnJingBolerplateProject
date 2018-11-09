using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AnJingBolerplateProject.Configuration.Dto;

namespace AnJingBolerplateProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AnJingBolerplateProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
