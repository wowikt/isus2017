using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SClassroom
    {
        public SClassroom()
        {
            FStudySchedule = new HashSet<FStudySchedule>();
        }

        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool? IsShareable { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FStudySchedule> FStudySchedule { get; set; }
    }
}
