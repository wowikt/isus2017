using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearMarkTypeValue : Entity
    {
        public int WorkYearMarkTypeId { get; set; }
        public string ValueStr { get; set; }
        public int ValueInt { get; set; }
        public bool? IsDefault { get; set; }

        public WorkYearMarkType WorkyearMarktype { get; set; }
    }
}
