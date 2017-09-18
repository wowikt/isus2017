using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObject : Entity
    {
        public AObject()
        {
            AObjectsEz = new HashSet<AObjectEz>();
            ATasksHookedObject = new HashSet<ATask>();
            ATasksPausedObject = new HashSet<ATask>();
            FObject = new HashSet<Fact>();
            FObjectIdOutNavigation = new HashSet<Fact>();
            SOpt = new HashSet<SEpt>();
        }

        public string DocNum { get; set; }
        public int? DocNumInt { get; set; }
        public DateTime DocDate { get; set; }
        public int? WorkYear { get; set; }
        public int? OrgId { get; set; }
        public string DocContent { get; set; }
        public string Data { get; set; }
        public int ObjectTypeId { get; set; }
        public int ObjectStateId { get; set; }
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

        public IsusUser Author { get; set; }
        public IsusUser Creator { get; set; }
        public IsusUser Expert { get; set; }
        public UserSession LockerSessionNavigation { get; set; }
        public CObjectState ObjectState { get; set; }
        public AObjectType ObjectType { get; set; }
        public SOrganization Org { get; set; }
        public WorkYearItem WorkYearItemObject { get; set; }
        public ICollection<AObjectEz> AObjectsEz { get; set; }
        public ICollection<ATask> ATasksHookedObject { get; set; }
        public ICollection<ATask> ATasksPausedObject { get; set; }
        public ICollection<Fact> FObject { get; set; }
        public ICollection<Fact> FObjectIdOutNavigation { get; set; }
        public ICollection<SEpt> SOpt { get; set; }
    }
}
