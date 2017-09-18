using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FGroupsBasicSostav
    {
        public int Uid { get; set; }
        public int PupilId { get; set; }
        public int BasicgroupId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public Users Pupil { get; set; }
        public F U { get; set; }
    }
}
