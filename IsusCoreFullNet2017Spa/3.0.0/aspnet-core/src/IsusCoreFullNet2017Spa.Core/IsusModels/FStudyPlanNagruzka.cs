using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlanNagruzka : Entity
    {
        public long PlanId { get; set; }
        public int Grade { get; set; }
        public double Hours { get; set; }

        public FStudyPlan Plan { get; set; }
    }
}
