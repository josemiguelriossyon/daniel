using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Testeando.AngularJS.Configuration.Dto;

namespace Testeando.AngularJS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularJSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
