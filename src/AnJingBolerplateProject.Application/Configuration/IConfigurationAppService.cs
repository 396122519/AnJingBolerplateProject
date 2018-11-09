using System.Threading.Tasks;
using AnJingBolerplateProject.Configuration.Dto;

namespace AnJingBolerplateProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
