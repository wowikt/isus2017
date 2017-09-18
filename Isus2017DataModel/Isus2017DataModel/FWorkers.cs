using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FWorkers
    {
        public int Uid { get; set; }
        public int WorkerId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int PositionId { get; set; }
        public int WorktypeId { get; set; }
        public int? EducationId { get; set; }
        public double? StavkaValue { get; set; }
        public double? StavkaNorma { get; set; }
        public bool? IsTeacher { get; set; }

        public CEducationTypes Education { get; set; }
        public SPositions Position { get; set; }
        public F U { get; set; }
        public Users Worker { get; set; }
        public CWorkTypes Worktype { get; set; }
    }
}
