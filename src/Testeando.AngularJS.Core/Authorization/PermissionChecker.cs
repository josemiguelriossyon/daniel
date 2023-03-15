using Abp.Authorization;
using Testeando.AngularJS.Authorization.Roles;
using Testeando.AngularJS.Authorization.Users;

namespace Testeando.AngularJS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
