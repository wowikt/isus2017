namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlanNagruzka
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int Grade { get; set; }
        public double Hours { get; set; }

        public FStudyPlan Plan { get; set; }
    }
}
