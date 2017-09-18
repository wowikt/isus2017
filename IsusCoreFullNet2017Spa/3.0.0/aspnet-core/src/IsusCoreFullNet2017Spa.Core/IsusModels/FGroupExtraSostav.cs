using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtraSostav : Entity<long>
    {
        public int PupilId { get; set; }
        public int ItemId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public FGroupExtraItem Item { get; set; }
        public IsusUser Pupil { get; set; }
    }
}
