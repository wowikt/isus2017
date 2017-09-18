using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FWorkersTeaching
    {
        public int Uid { get; set; }
        public int TeacherId { get; set; }
        public int ActivityId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public SActivities Activity { get; set; }
        public CWorkCategories Category { get; set; }
        public Users Teacher { get; set; }
        public F U { get; set; }
    }
}
