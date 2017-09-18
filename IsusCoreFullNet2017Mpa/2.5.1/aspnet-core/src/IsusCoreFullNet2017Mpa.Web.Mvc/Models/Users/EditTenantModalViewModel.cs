using System.Collections.Generic;
using System.Linq;
using IsusCoreFullNet2017Mpa.Roles.Dto;
using IsusCoreFullNet2017Mpa.Users.Dto;

namespace IsusCoreFullNet2017Mpa.Web.Models.Users
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