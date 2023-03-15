using Abp.AutoMapper;
using Testeando.AngularJS.Sessions.Dto;

namespace Testeando.AngularJS.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}