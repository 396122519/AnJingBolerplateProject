using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AnJingBolerplateProject.MultiTenancy.Dto;

namespace AnJingBolerplateProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
