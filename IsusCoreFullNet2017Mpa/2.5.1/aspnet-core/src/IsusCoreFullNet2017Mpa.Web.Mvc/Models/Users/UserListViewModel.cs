using System.Collections.Generic;
using IsusCoreFullNet2017Mpa.Roles.Dto;
using IsusCoreFullNet2017Mpa.Users.Dto;

namespace IsusCoreFullNet2017Mpa.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}