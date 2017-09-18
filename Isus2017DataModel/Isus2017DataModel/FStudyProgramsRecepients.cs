using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyProgramsRecepients
    {
        public int Uid { get; set; }
        public int FactId { get; set; }
        public int? BasicgroupId { get; set; }
        public int? ExtragroupId { get; set; }

        public FGroupsExtraItems Extragroup { get; set; }
        public FStudyPrograms Fact { get; set; }
    }
}
