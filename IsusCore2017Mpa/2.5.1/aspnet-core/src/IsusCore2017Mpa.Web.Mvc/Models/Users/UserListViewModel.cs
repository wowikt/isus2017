using System.Collections.Generic;
using IsusCore2017Mpa.Roles.Dto;
using IsusCore2017Mpa.Users.Dto;

namespace IsusCore2017Mpa.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}