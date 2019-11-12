using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TheEndProject.Roles.Dto;
using TheEndProject.Users.Dto;

namespace TheEndProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
