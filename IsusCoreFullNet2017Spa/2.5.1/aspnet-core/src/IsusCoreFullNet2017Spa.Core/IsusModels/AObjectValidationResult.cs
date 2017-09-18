namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectValidationResult
    {
        public int Id { get; set; }
        public int ValidationId { get; set; }
        public string Category { get; set; }
        public string Descr { get; set; }

        public AObjectValidation Validation { get; set; }
    }
}
