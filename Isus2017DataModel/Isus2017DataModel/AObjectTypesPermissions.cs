using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectTypesPermissions
    {
        public int Uid { get; set; }
        public int UserId { get; set; }
        public int ObjectypeId { get; set; }
        public int Permissions { get; set; }

        public AObjectTypes Objectype { get; set; }
        public Users User { get; set; }
    }
}
