using Abp.Authorization;
using Isus2017Spa.Authorization.Roles;
using Isus2017Spa.Authorization.Users;

namespace Isus2017Spa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
