using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupBasicSostav : Entity<long>
    {
        public int PupilId { get; set; }
        public int BasicGroupId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public IsusUser Pupil { get; set; }
        public Fact Fact { get; set; }
    }
}
