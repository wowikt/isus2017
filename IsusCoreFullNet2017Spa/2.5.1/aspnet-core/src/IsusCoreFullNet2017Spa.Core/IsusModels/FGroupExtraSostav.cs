using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtraSostav
    {
        public int Id { get; set; }
        public int PupilId { get; set; }
        public int ItemId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public FGroupExtraItem Item { get; set; }
        public IsusUser Pupil { get; set; }
    }
}
