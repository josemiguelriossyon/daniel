using System.Threading.Tasks;
using Abp.Application.Services;
using Testeando.AngularJS.Sessions.Dto;

namespace Testeando.AngularJS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
