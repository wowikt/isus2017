namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlanRecepient
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int BasicGroupId { get; set; }

        public FStudyPlan Plan { get; set; }
    }
}
