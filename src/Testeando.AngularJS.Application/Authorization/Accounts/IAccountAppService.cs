using System.Threading.Tasks;
using Abp.Application.Services;
using Testeando.AngularJS.Authorization.Accounts.Dto;

namespace Testeando.AngularJS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
