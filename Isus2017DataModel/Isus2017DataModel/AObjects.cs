using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjects
    {
        public AObjects()
        {
            AObjectsEz = new HashSet<AObjectsEz>();
            ATasksHookedObject = new HashSet<ATasks>();
            ATasksPausedObject = new HashSet<ATasks>();
            FObject = new HashSet<F>();
            FObjectIdOutNavigation = new HashSet<F>();
            SOpt = new HashSet<SOpt>();
        }

        public int Uid { get; set; }
        public string DocNum { get; set; }
        public int? DocNumInt { get; set; }
        public DateTime DocDate { get; set; }
        public int? WorkYear { get; set; }
        public int? OrgId { get; set; }
        public string DocContent { get; set; }
        public string Data { get; set; }
        public int ObjectypeId { get; set; }
        public int ObjectstateId { get; set; }
        public int CreatorId { get; set; }
        public int? ExpertId { get; set; }
        public int? AuthorId { get; set; }
        public string LockerSession { get; set; }
        public bool? IsAutoNum { get; set; }
        public bool? IsEmpty { get; set; }
        public bool? IsDeleted { get; set; }
        public int CounterIterations { get; set; }
        public int CounterExpertRejects { get; set; }
        public int CounterAuthorRejects { get; set; }
        public DateTime? FirstProjectDate { get; set; }

        public Users Author { get; set; }
        public Users Creator { get; set; }
        public Users Expert { get; set; }
        public UsersSessions LockerSessionNavigation { get; set; }
        public CObjectStates Objectstate { get; set; }
        public AObjectTypes Objectype { get; set; }
        public SOrganizations Org { get; set; }
        public WorkYears WorkYearNavigation { get; set; }
        public ICollection<AObjectsEz> AObjectsEz { get; set; }
        public ICollection<ATasks> ATasksHookedObject { get; set; }
        public ICollection<ATasks> ATasksPausedObject { get; set; }
        public ICollection<F> FObject { get; set; }
        public ICollection<F> FObjectIdOutNavigation { get; set; }
        public ICollection<SOpt> SOpt { get; set; }
    }
}
