using Abp.MultiTenancy;
using Testeando.AngularJS.Authorization.Users;

namespace Testeando.AngularJS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}