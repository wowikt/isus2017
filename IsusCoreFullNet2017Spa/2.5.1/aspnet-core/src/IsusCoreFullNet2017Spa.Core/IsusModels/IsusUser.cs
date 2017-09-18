using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class IsusUser : IEntity<int>
    {
        public IsusUser()
        {
            AObjectTypesPermissions = new HashSet<AObjectTypePermission>();
            AObjectsAuthor = new HashSet<AObject>();
            AObjectsCreator = new HashSet<AObject>();
            AObjectsExpert = new HashSet<AObject>();
            ATasksAuthor = new HashSet<ATask>();
            ATasksReceiver = new HashSet<ATask>();
            FEducationCud = new HashSet<FEducationCud>();
            FEducationResults = new HashSet<FEducationResult>();
            FEducationResultsFinal = new HashSet<FEducationResultFinal>();
            FEducationStudyingMainMarks = new HashSet<FEducationStudyingMainMark>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMark>();
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FExpertsStudyProgram = new HashSet<FExpertStudyProgram>();
            FGroupsBasicSostav = new HashSet<FGroupBasicSostav>();
            FGroupsExtraSostav = new HashSet<FGroupExtraSostav>();
            FStudyJobsMetodist = new HashSet<FStudyJob>();
            FStudyJobsTeacher = new HashSet<FStudyJob>();
            FStudySchedule = new HashSet<FStudySchedule>();
            FWorkers = new HashSet<FWorker>();
            FWorkersTeaching = new HashSet<FWorkerTeaching>();
            SOpt = new HashSet<SOpt>();
            UsersParentshipChild = new HashSet<UserParentship>();
            UsersParentshipParent = new HashSet<UserParentship>();
            UsersSessions = new HashSet<UserSession>();
        }

        public int Id { get; set; }
        public string CurrentName { get; set; }
        public string CurrentShortName { get; set; }
        public string Data { get; set; }
        public byte[] Photo { get; set; }
        public string Email { get; set; }
        public bool? IsDeveloper { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsBoss { get; set; }
        public string AccountName { get; set; }
        public string AccountPwd { get; set; }
        public byte[] AccountPwdMd5 { get; set; }
        public bool? AccountValid { get; set; }
        public bool? SurplusIsTeacher { get; set; }
        public int? SurplusKlassId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Tmp { get; set; }
        public string ContactInfo { get; set; }

        public ICollection<AObjectTypePermission> AObjectTypesPermissions { get; set; }
        public ICollection<AObject> AObjectsAuthor { get; set; }
        public ICollection<AObject> AObjectsCreator { get; set; }
        public ICollection<AObject> AObjectsExpert { get; set; }
        public ICollection<ATask> ATasksAuthor { get; set; }
        public ICollection<ATask> ATasksReceiver { get; set; }
        public ICollection<FEducationCud> FEducationCud { get; set; }
        public ICollection<FEducationResult> FEducationResults { get; set; }
        public ICollection<FEducationResultFinal> FEducationResultsFinal { get; set; }
        public ICollection<FEducationStudyingMainMark> FEducationStudyingMainMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMark> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FExpertStudyProgram> FExpertsStudyProgram { get; set; }
        public ICollection<FGroupBasicSostav> FGroupsBasicSostav { get; set; }
        public ICollection<FGroupExtraSostav> FGroupsExtraSostav { get; set; }
        public ICollection<FStudyJob> FStudyJobsMetodist { get; set; }
        public ICollection<FStudyJob> FStudyJobsTeacher { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
        public ICollection<FWorker> FWorkers { get; set; }
        public ICollection<FWorkerTeaching> FWorkersTeaching { get; set; }
        public ICollection<SOpt> SOpt { get; set; }
        public ICollection<UserParentship> UsersParentshipChild { get; set; }
        public ICollection<UserParentship> UsersParentshipParent { get; set; }
        public ICollection<UserSession> UsersSessions { get; set; }

        public bool IsTransient()
        {
            return false;
        }
    }
}
