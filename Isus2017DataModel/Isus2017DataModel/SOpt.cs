using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SOpt
    {
        public SOpt()
        {
            FStudyProgramsContent = new HashSet<FStudyProgramsContent>();
        }

        public int Uid { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int ActivityId { get; set; }
        public string Grades { get; set; }
        public int Hours { get; set; }
        public string TargetStudy { get; set; }
        public string TargetDeveloping { get; set; }
        public string TargetTeaching { get; set; }
        public string Result { get; set; }
        public string SimpleResources { get; set; }
        public string SimpleKim { get; set; }
        public string OrgForm { get; set; }
        public string LeadingFormUd { get; set; }
        public bool? IsShareable { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DocId { get; set; }
        public bool? IsFrozen { get; set; }

        public SActivities Activity { get; set; }
        public Users Author { get; set; }
        public AObjects Doc { get; set; }
        public ICollection<FStudyProgramsContent> FStudyProgramsContent { get; set; }
    }
}
