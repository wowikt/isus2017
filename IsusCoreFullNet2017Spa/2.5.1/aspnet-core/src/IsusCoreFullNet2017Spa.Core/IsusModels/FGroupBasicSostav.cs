using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupBasicSostav
    {
        public int Id { get; set; }
        public int PupilId { get; set; }
        public int BasicGroupId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
    }
}
