using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Testeando.AngularJS.Roles.Dto;

namespace Testeando.AngularJS.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
