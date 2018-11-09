using System.Threading.Tasks;
using Abp.Application.Services;
using AnJingBolerplateProject.Sessions.Dto;

namespace AnJingBolerplateProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
