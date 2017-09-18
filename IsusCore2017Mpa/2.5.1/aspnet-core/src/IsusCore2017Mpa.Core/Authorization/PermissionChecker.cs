using Abp.Authorization;
using IsusCore2017Mpa.Authorization.Roles;
using IsusCore2017Mpa.Authorization.Users;

namespace IsusCore2017Mpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
