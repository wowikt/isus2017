namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlanContent
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int ActivityId { get; set; }
        public int Grade { get; set; }
        public double Hours { get; set; }

        public SActivity Activity { get; set; }
        public FStudyPlan Plan { get; set; }
    }
}
