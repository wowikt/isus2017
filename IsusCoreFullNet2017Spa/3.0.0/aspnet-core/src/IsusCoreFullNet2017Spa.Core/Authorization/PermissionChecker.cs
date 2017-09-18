using Abp.Authorization;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;

namespace IsusCoreFullNet2017Spa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
