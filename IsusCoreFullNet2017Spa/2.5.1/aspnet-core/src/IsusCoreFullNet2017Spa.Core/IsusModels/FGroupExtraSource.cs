namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtraSource
    {
        public int Id { get; set; }
        public int FactId { get; set; }
        public int BasicGroupId { get; set; }

        public FGroupExtra Fact { get; set; }
    }
}
