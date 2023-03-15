using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Testeando.AngularJS.Roles.Dto;
using Testeando.AngularJS.Users.Dto;

namespace Testeando.AngularJS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}