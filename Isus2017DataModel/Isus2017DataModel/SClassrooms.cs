using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SClassrooms
    {
        public SClassrooms()
        {
            FStudySchedule = new HashSet<FStudySchedule>();
        }

        public int Uid { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool? IsShareable { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FStudySchedule> FStudySchedule { get; set; }
    }
}
