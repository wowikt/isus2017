﻿using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyJobs
    {
        public int Uid { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int ActivityId { get; set; }
        public double Hours { get; set; }
        public int? BasicgroupId { get; set; }
        public int? ExtragroupId { get; set; }
        public int TeacherId { get; set; }
        public int MetodistId { get; set; }

        public SActivities Activity { get; set; }
        public FGroupsExtraItems Extragroup { get; set; }
        public Users Metodist { get; set; }
        public Users Teacher { get; set; }
        public F U { get; set; }
    }
}
