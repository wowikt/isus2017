using Abp.Authorization;
using IsusCore2017Spa.Authorization.Roles;
using IsusCore2017Spa.Authorization.Users;

namespace IsusCore2017Spa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
