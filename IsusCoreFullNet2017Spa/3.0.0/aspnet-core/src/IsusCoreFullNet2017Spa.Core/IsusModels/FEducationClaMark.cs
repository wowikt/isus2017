using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationClaMark : Entity
    {
        public long FactId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public FEducationCla EducationCla { get; set; }
        public CMarkType Marktype { get; set; }
    }
}
