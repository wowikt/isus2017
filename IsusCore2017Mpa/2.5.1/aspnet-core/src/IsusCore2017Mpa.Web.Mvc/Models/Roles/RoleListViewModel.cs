using System.Collections.Generic;
using IsusCore2017Mpa.Roles.Dto;

namespace IsusCore2017Mpa.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
