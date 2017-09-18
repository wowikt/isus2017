using System.Collections.Generic;
using System.Linq;
using IsusCore2017Mpa.Roles.Dto;
using IsusCore2017Mpa.Users.Dto;

namespace IsusCore2017Mpa.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}