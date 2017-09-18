using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class UsersParentship
    {
        public int Uid { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescr { get; set; }

        public Users Child { get; set; }
        public Users Parent { get; set; }
    }
}
