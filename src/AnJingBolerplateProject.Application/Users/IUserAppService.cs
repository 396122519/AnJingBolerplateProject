using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AnJingBolerplateProject.Roles.Dto;
using AnJingBolerplateProject.Users.Dto;

namespace AnJingBolerplateProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
