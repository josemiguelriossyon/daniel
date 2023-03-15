using System.Threading.Tasks;
using Abp.Application.Services;
using Testeando.AngularJS.Configuration.Dto;

namespace Testeando.AngularJS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}