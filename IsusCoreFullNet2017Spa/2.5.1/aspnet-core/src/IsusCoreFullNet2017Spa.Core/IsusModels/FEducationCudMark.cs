namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationCudMark
    {
        public int Id { get; set; }
        public int FactId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public FEducationCud Fact { get; set; }
        public CMarkType Marktype { get; set; }
    }
}
