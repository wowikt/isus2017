using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectTypes
    {
        public AObjectTypes()
        {
            AObjectTypesPermissions = new HashSet<AObjectTypesPermissions>();
            AObjects = new HashSet<AObjects>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public bool? DirectInput { get; set; }
        public bool? AutoAffirm { get; set; }
        public bool? CreatorSolo { get; set; }
        public bool? ShowInList { get; set; }
        public string ProcDataLoader { get; set; }
        public string ProcSaveTrigger { get; set; }
        public string ProcContentor { get; set; }
        public string ProcValidator { get; set; }
        public string ProcPoster { get; set; }
        public bool? IsYeared { get; set; }
        public bool? IsOrged { get; set; }
        public bool? IsUniqueNum { get; set; }
        public int? DivisionId { get; set; }
        public int PermissionMask { get; set; }
        public int? JournalId { get; set; }
        public bool? IsObsolete { get; set; }
        public int Compatibility { get; set; }

        public CDivisions Division { get; set; }
        public AObjectTypesJournals Journal { get; set; }
        public ICollection<AObjectTypesPermissions> AObjectTypesPermissions { get; set; }
        public ICollection<AObjects> AObjects { get; set; }
    }
}
