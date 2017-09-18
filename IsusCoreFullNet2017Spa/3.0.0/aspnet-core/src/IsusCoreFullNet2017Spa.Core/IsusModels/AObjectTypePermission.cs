using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectTypePermission : Entity
    {
        public int UserId { get; set; }
        public int ObjectTypeId { get; set; }
        public int Permissions { get; set; }

        public AObjectType ObjectType { get; set; }
        public IsusUser IsusUser { get; set; }
    }
}
