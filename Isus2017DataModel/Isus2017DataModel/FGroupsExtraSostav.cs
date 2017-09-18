using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FGroupsExtraSostav
    {
        public int Uid { get; set; }
        public int PupilId { get; set; }
        public int ItemId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public FGroupsExtraItems Item { get; set; }
        public Users Pupil { get; set; }
    }
}
