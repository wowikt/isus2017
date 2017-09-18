using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class UserParentship : Entity
    {
        public long ParentId { get; set; }
        public long ChildId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescr { get; set; }

        public IsusUser Child { get; set; }
        public IsusUser Parent { get; set; }
    }
}
