using System.Collections.Generic;
using IsusCoreFullNet2017Mpa.Roles.Dto;

namespace IsusCoreFullNet2017Mpa.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
