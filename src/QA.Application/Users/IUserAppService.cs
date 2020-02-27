using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QA.Roles.Dto;
using QA.Users.Dto;

namespace QA.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
