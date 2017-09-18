using Abp.Authorization;
using IsusCoreFullNet2017Mpa.Authorization.Roles;
using IsusCoreFullNet2017Mpa.Authorization.Users;

namespace IsusCoreFullNet2017Mpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
