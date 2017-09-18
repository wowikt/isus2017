using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlanRecepient : Entity
    {
        public long PlanId { get; set; }
        public int BasicGroupId { get; set; }

        public FStudyPlan Plan { get; set; }
    }
}
