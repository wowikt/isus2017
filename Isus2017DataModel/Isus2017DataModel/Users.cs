using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class Users
    {
        public Users()
        {
            AObjectTypesPermissions = new HashSet<AObjectTypesPermissions>();
            AObjectsAuthor = new HashSet<AObjects>();
            AObjectsCreator = new HashSet<AObjects>();
            AObjectsExpert = new HashSet<AObjects>();
            ATasksAuthor = new HashSet<ATasks>();
            ATasksReceiver = new HashSet<ATasks>();
            FEducationCud = new HashSet<FEducationCud>();
            FEducationResults = new HashSet<FEducationResults>();
            FEducationResultsFinal = new HashSet<FEducationResultsFinal>();
            FEducationStudyingMainMarks = new HashSet<FEducationStudyingMainMarks>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMarks>();
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FExpertsStudyProgram = new HashSet<FExpertsStudyProgram>();
            FGroupsBasicSostav = new HashSet<FGroupsBasicSostav>();
            FGroupsExtraSostav = new HashSet<FGroupsExtraSostav>();
            FStudyJobsMetodist = new HashSet<FStudyJobs>();
            FStudyJobsTeacher = new HashSet<FStudyJobs>();
            FStudySchedule = new HashSet<FStudySchedule>();
            FWorkers = new HashSet<FWorkers>();
            FWorkersTeaching = new HashSet<FWorkersTeaching>();
            SOpt = new HashSet<SOpt>();
            UsersParentshipChild = new HashSet<UsersParentship>();
            UsersParentshipParent = new HashSet<UsersParentship>();
            UsersSessions = new HashSet<UsersSessions>();
        }

        public int Uid { get; set; }
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

        public ICollection<AObjectTypesPermissions> AObjectTypesPermissions { get; set; }
        public ICollection<AObjects> AObjectsAuthor { get; set; }
        public ICollection<AObjects> AObjectsCreator { get; set; }
        public ICollection<AObjects> AObjectsExpert { get; set; }
        public ICollection<ATasks> ATasksAuthor { get; set; }
        public ICollection<ATasks> ATasksReceiver { get; set; }
        public ICollection<FEducationCud> FEducationCud { get; set; }
        public ICollection<FEducationResults> FEducationResults { get; set; }
        public ICollection<FEducationResultsFinal> FEducationResultsFinal { get; set; }
        public ICollection<FEducationStudyingMainMarks> FEducationStudyingMainMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMarks> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FExpertsStudyProgram> FExpertsStudyProgram { get; set; }
        public ICollection<FGroupsBasicSostav> FGroupsBasicSostav { get; set; }
        public ICollection<FGroupsExtraSostav> FGroupsExtraSostav { get; set; }
        public ICollection<FStudyJobs> FStudyJobsMetodist { get; set; }
        public ICollection<FStudyJobs> FStudyJobsTeacher { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
        public ICollection<FWorkers> FWorkers { get; set; }
        public ICollection<FWorkersTeaching> FWorkersTeaching { get; set; }
        public ICollection<SOpt> SOpt { get; set; }
        public ICollection<UsersParentship> UsersParentshipChild { get; set; }
        public ICollection<UsersParentship> UsersParentshipParent { get; set; }
        public ICollection<UsersSessions> UsersSessions { get; set; }
    }
}
