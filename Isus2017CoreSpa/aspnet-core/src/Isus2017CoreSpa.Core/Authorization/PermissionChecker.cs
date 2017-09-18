using Abp.Authorization;
using Isus2017CoreSpa.Authorization.Roles;
using Isus2017CoreSpa.Authorization.Users;

namespace Isus2017CoreSpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
