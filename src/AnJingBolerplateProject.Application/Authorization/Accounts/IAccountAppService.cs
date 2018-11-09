using System.Threading.Tasks;
using Abp.Application.Services;
using AnJingBolerplateProject.Authorization.Accounts.Dto;

namespace AnJingBolerplateProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
