using Abp.Zero.EntityFrameworkCore;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.IsusModels;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore
{
    public class IsusCoreFullNet2017SpaDbContext : AbpZeroDbContext<Tenant, Role, User, IsusCoreFullNet2017SpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public IsusCoreFullNet2017SpaDbContext(DbContextOptions<IsusCoreFullNet2017SpaDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AObject> AObjects { get; set; }
        public virtual DbSet<AObjectEz> AObjectsEz { get; set; }
        public virtual DbSet<AObjectValidation> AObjectsValidation { get; set; }
        public virtual DbSet<AObjectValidationResult> AObjectsValidationResults { get; set; }
        public virtual DbSet<AObjectType> AObjectTypes { get; set; }
        public virtual DbSet<AObjectTypeJournal> AObjectTypesJournals { get; set; }
        public virtual DbSet<AObjectTypePermission> AObjectTypesPermissions { get; set; }
        public virtual DbSet<ATask> ATasks { get; set; }
        public virtual DbSet<AVariable> AVariables { get; set; }
        public virtual DbSet<CActivityType> CActivityTypes { get; set; }
        public virtual DbSet<CDivision> CDivisions { get; set; }
        public virtual DbSet<CEducationType> CEducationTypes { get; set; }
        public virtual DbSet<CMarkType> CMarkTypes { get; set; }
        public virtual DbSet<CObjectState> CObjectStates { get; set; }
        public virtual DbSet<CPeriodType> CPeriodTypes { get; set; }
        public virtual DbSet<CWorkCategory> CWorkCategories { get; set; }
        public virtual DbSet<CWorkType> CWorkTypes { get; set; }
        public virtual DbSet<Fact> F { get; set; }
        public virtual DbSet<FEducationCud> FEducationCud { get; set; }
        public virtual DbSet<FEducationCudMark> FEducationCudMarks { get; set; }
        public virtual DbSet<FEducationResult> FEducationResults { get; set; }
        public virtual DbSet<FEducationResultFinal> FEducationResultsFinal { get; set; }
        public virtual DbSet<FEducationStudyingMainMark> FEducationStudyingMainMarks { get; set; }
        public virtual DbSet<FEducationStudyingSpecialMark> FEducationStudyingSpecialMarks { get; set; }
        public virtual DbSet<FEducationTeaching> FEducationTeaching { get; set; }
        public virtual DbSet<FExpertStudyProgram> FExpertsStudyProgram { get; set; }
        public virtual DbSet<FGroupBasicSostav> FGroupsBasicSostav { get; set; }
        public virtual DbSet<FGroupExtra> FGroupsExtra { get; set; }
        public virtual DbSet<FGroupExtraItem> FGroupsExtraItems { get; set; }
        public virtual DbSet<FGroupExtraSostav> FGroupsExtraSostav { get; set; }
        public virtual DbSet<FGroupExtraSource> FGroupsExtraSources { get; set; }
        public virtual DbSet<FStudyJob> FStudyJobs { get; set; }
        public virtual DbSet<FStudyPlan> FStudyPlans { get; set; }
        public virtual DbSet<FStudyPlanContent> FStudyPlansContent { get; set; }
        public virtual DbSet<FStudyPlanNagruzka> FStudyPlansNagruzka { get; set; }
        public virtual DbSet<FStudyPlanRecepient> FStudyPlansRecepients { get; set; }
        public virtual DbSet<FStudyProgram> FStudyPrograms { get; set; }
        public virtual DbSet<FStudyProgramContent> FStudyProgramsContent { get; set; }
        public virtual DbSet<FStudyProgramRecepient> FStudyProgramsRecepients { get; set; }
        public virtual DbSet<FStudySchedule> FStudySchedule { get; set; }
        public virtual DbSet<FWorker> FWorkers { get; set; }
        public virtual DbSet<FWorkerTeaching> FWorkersTeaching { get; set; }
        public virtual DbSet<SActivity> SActivities { get; set; }
        public virtual DbSet<SClassroom> SClassrooms { get; set; }
        public virtual DbSet<SiteDocument> SiteDocuments { get; set; }
        public virtual DbSet<SOpt> SOpt { get; set; }
        public virtual DbSet<SOrganization> SOrganizations { get; set; }
        public virtual DbSet<SPosition> SPositions { get; set; }
        public virtual DbSet<IsusUser> IsusUsers { get; set; }
        public virtual DbSet<UserOrganizer> UsersOrganizer { get; set; }
        public virtual DbSet<UserParentship> UsersParentship { get; set; }
        public virtual DbSet<UserSession> UsersSessions { get; set; }
        public virtual DbSet<WorkYearItem> WorkYears { get; set; }
        public virtual DbSet<WorkYearGroupBasic> WorkYearsGroupsBasic { get; set; }
        public virtual DbSet<WorkYearMarkType> WorkYearsMarkTypes { get; set; }
        public virtual DbSet<WorkYearMarkTypeValue> WorkYearsMarkTypesValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AObject>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Objects");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CounterAuthorRejects)
                    .HasColumnName("counter_AuthorRejects")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CounterExpertRejects)
                    .HasColumnName("counter_ExpertRejects")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CounterIterations)
                    .HasColumnName("counter_Iterations")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.DocDate);

                entity.Property(e => e.DocNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocNumInt).HasColumnName("DocNum_Int");

                entity.Property(e => e.ExpertId).HasColumnName("expert_id");

                entity.Property(e => e.FirstProjectDate);

                entity.Property(e => e.IsAutoNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmpty).HasDefaultValueSql("((1))");

                entity.Property(e => e.LockerSession)
                    .HasColumnName("locker_session")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectStateId).HasColumnName("objectstate_id");

                entity.Property(e => e.ObjectTypeId).HasColumnName("objectype_id");

                entity.Property(e => e.OrgId).HasColumnName("org_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AObjectsAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_A_Objects_Users2");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.AObjectsCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_A_Objects_Users");

                entity.HasOne(d => d.Expert)
                    .WithMany(p => p.AObjectsExpert)
                    .HasForeignKey(d => d.ExpertId)
                    .HasConstraintName("FK_A_Objects_Users1");

                entity.HasOne(d => d.LockerSessionNavigation)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.LockerSession)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_A_Objects_Users_Sessions");

                entity.HasOne(d => d.ObjectState)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.ObjectStateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_A_Objects_C_ObjectStates");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_A_Objects_A_ObjectTypes");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_A_Objects_S_Organizations");

                entity.HasOne(d => d.WorkYearItemObject)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_A_Objects_WorkYears");
            });

            modelBuilder.Entity<AObjectEz>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Objects_EZ");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.EzContent)
                    .IsRequired()
                    .HasColumnName("ez_content")
                    .HasMaxLength(500);

                entity.Property(e => e.EzData)
                    .IsRequired()
                    .HasColumnName("ez_data")
                    .HasColumnType("xml");

                entity.Property(e => e.EzDate)
                    .HasColumnName("ez_date");

                entity.Property(e => e.EzSigma)
                    .HasColumnName("ez_sigma")
                    .HasMaxLength(500);

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.AObjectsEz)
                    .HasForeignKey(d => d.ObjectId)
                    .HasConstraintName("FK_A_Objects_EZ_A_Objects");
            });

            modelBuilder.Entity<AObjectValidation>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Objects_Validation");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectStateId).HasColumnName("objectstate_id");

                entity.Property(e => e.Session)
                    .IsRequired()
                    .HasColumnName("session")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ObjectState)
                    .WithMany(p => p.AObjectsValidation)
                    .HasForeignKey(d => d.ObjectStateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_A_Objects_Validation_C_ObjectStates");

                entity.HasOne(d => d.SessionNavigation)
                    .WithMany(p => p.AObjectsValidation)
                    .HasForeignKey(d => d.Session)
                    .HasConstraintName("FK_A_Objects_Validation_Users_Sessions");
            });

            modelBuilder.Entity<AObjectValidationResult>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Objects_Validation_Results");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnName("descr")
                    .HasMaxLength(500);

                entity.Property(e => e.ValidationId).HasColumnName("validation_id");

                entity.HasOne(d => d.Validation)
                    .WithMany(p => p.AObjectsValidationResults)
                    .HasForeignKey(d => d.ValidationId)
                    .HasConstraintName("FK_A_Objects_Validation_Results_A_Objects_Validation");
            });

            modelBuilder.Entity<AObjectType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_ObjectTypes");

                entity.HasIndex(e => e.Label)
                    .HasName("uc_Label")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoAffirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Compatibility).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatorSolo).HasDefaultValueSql("((0))");

                entity.Property(e => e.DirectInput).HasDefaultValueSql("((1))");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.IsObsolete).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOrged).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUniqueNum).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsYeared).HasDefaultValueSql("((0))");

                entity.Property(e => e.JournalId).HasColumnName("journal_id");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PermissionMask).HasDefaultValueSql("((11))");

                entity.Property(e => e.ProcContentor).HasMaxLength(500);

                entity.Property(e => e.ProcDataLoader).HasMaxLength(500);

                entity.Property(e => e.ProcPoster).HasMaxLength(500);

                entity.Property(e => e.ProcSaveTrigger).HasMaxLength(500);

                entity.Property(e => e.ProcValidator).HasMaxLength(500);

                entity.Property(e => e.ShowInList).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AObjectTypes)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_A_ObjectTypes_C_Divisions");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.AObjectTypes)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_A_ObjectTypes_A_ObjectTypes_Journals");
            });

            modelBuilder.Entity<AObjectTypeJournal>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_ObjectTypes_Journals");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Postfix)
                    .IsRequired()
                    .HasColumnName("postfix")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResetMonth).HasColumnName("reset_month");
            });

            modelBuilder.Entity<AObjectTypePermission>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_ObjectTypes_Permissions");

                entity.HasIndex(e => new { ObjectypeId = e.ObjectTypeId, e.UserId })
                    .HasName("IX_A_ObjectTypes_Permissions")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.ObjectTypeId).HasColumnName("objectype_id");

                entity.Property(e => e.Permissions).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.AObjectTypesPermissions)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .HasConstraintName("FK_A_ObjectTypes_Permissions_A_ObjectTypes");

                entity.HasOne(d => d.IsusUser)
                    .WithMany(p => p.AObjectTypesPermissions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_A_ObjectTypes_Permissions_Users");
            });

            modelBuilder.Entity<ATask>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Tasks");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.Failtime)
                    .HasColumnName("failtime");

                entity.Property(e => e.HookedObjectId).HasColumnName("hooked_object_id");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PausedObjectId).HasColumnName("paused_object_id");

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.Showtime)
                    .HasColumnName("showtime");

                entity.Property(e => e.Txt).HasMaxLength(500);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.ATasksAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_A_Tasks_Users");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.ATasks)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_A_Tasks_F");

                entity.HasOne(d => d.HookedObject)
                    .WithMany(p => p.ATasksHookedObject)
                    .HasForeignKey(d => d.HookedObjectId)
                    .HasConstraintName("FK_A_Tasks_A_Objects");

                entity.HasOne(d => d.PausedObject)
                    .WithMany(p => p.ATasksPausedObject)
                    .HasForeignKey(d => d.PausedObjectId)
                    .HasConstraintName("FK_A_Tasks_A_Objects1");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.ATasksReceiver)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_A_Tasks_Users1");
            });

            modelBuilder.Entity<AVariable>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("A_Variables");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValueBinary).HasColumnName("value_binary");

                entity.Property(e => e.ValueBit).HasColumnName("value_bit");

                entity.Property(e => e.ValueDatetime)
                    .HasColumnName("value_datetime");

                entity.Property(e => e.ValueInt).HasColumnName("value_int");

                entity.Property(e => e.ValueStr)
                    .HasColumnName("value_str")
                    .HasMaxLength(500);

                entity.Property(e => e.ValueXml)
                    .HasColumnName("value_xml")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<CActivityType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_ActivityTypes");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CDivision>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_Divisions");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CEducationType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_EducationTypes");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CMarkType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_MarkTypes");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CObjectState>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_ObjectStates");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CPeriodType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_PeriodTypes");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodGroup)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CWorkCategory>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_WorkCategories");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CWorkType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("C_WorkTypes");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Fact>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectIdOut).HasColumnName("object_id_out");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.FObject)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_A_Objects");

                entity.HasOne(d => d.ObjectIdOutNavigation)
                    .WithMany(p => p.FObjectIdOutNavigation)
                    .HasForeignKey(d => d.ObjectIdOut)
                    .HasConstraintName("FK_F_A_Objects1");

                entity.HasOne(d => d.WorkYearItemNavigation)
                    .WithMany(p => p.F)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_F_WorkYears");
            });

            modelBuilder.Entity<FEducationCud>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_CUD");

                entity.HasIndex(e => new { Uid = e.Id, e.ActivityId, e.ProgOptId, e.CudText, e.PupilId })
                    .HasName("IX_FEducationCUD_PupilId");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CudText)
                    .HasColumnName("cud_text");

                entity.Property(e => e.ProgOptId).HasColumnName("prog_opt_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_CUD_S_Activities");

                entity.HasOne(d => d.ProgOpt)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.ProgOptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_CUD_F_StudyPrograms_Content");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_CUD_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationCud)
                    .HasForeignKey<FEducationCud>(d => d.Id)
                    .HasConstraintName("FK_F_Education_CUD_F");
            });

            modelBuilder.Entity<FEducationCudMark>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_CUD_Marks");

                entity.HasIndex(e => new { e.MarktypeId, e.MarkValue, e.FactId })
                    .HasName("IX_FEducationCUDMarks_FactId");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.MarkValue).HasColumnName("mark_value");

                entity.Property(e => e.MarktypeId).HasColumnName("marktype_id");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FEducationCudMarks)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_Education_CUD_Marks_F_Education_CUD");

                entity.HasOne(d => d.Marktype)
                    .WithMany(p => p.FEducationCudMarks)
                    .HasForeignKey(d => d.MarktypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_CUD_Marks_C_MarkTypes");
            });

            modelBuilder.Entity<FEducationResult>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_Results");

                entity.HasIndex(e => new { e.PupilId, e.ActivityId, e.PeriodId })
                    .HasName("IX_F_Education_Results")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.MarkMain).HasColumnName("mark_main");

                entity.Property(e => e.PeriodId).HasColumnName("period_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Results_S_Activities");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Results_C_PeriodTypes");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_Education_Results_F_StudyPlans");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Results_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationResult)
                    .HasForeignKey<FEducationResult>(d => d.Id)
                    .HasConstraintName("FK_F_Education_Results_F");
            });

            modelBuilder.Entity<FEducationResultFinal>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_Results_Final");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.MarkExam).HasColumnName("mark_exam");

                entity.Property(e => e.MarkGod).HasColumnName("mark_god");

                entity.Property(e => e.MarkItog).HasColumnName("mark_itog");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationResultsFinal)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Results_Final_S_Activities");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationResultsFinal)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Results_Final_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationResultFinal)
                    .HasForeignKey<FEducationResultFinal>(d => d.Id)
                    .HasConstraintName("FK_F_Education_Results_Final_F");
            });

            modelBuilder.Entity<FEducationStudyingMainMark>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_Studying_MainMarks");

                entity.HasIndex(e => new { e.PupilId, e.IsAbsent, e.DtStart })
                    .HasName("IX_Education_Studying_MainMarks_PupilId_IsAbsent_DtStart");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.LessonLength).HasColumnName("lesson_length");

                entity.Property(e => e.MarkType)
                    .IsRequired()
                    .HasColumnName("mark_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkValue).HasColumnName("mark_value");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.Property(e => e.TimeLate)
                    .HasColumnName("time_late")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationStudyingMainMarks)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_S_Activities");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationStudyingMainMarks)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationStudyingMainMark)
                    .HasForeignKey<FEducationStudyingMainMark>(d => d.Id)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_F");
            });

            modelBuilder.Entity<FEducationStudyingSpecialMark>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_Studying_SpecialMarks");

                entity.HasIndex(e => new { e.LessonVolume, e.ActivityId, e.MarktypeId, e.MarkValue, e.PupilId, e.EduDate })
                    .HasName("IX_FEducationStudyingSpecialMarks_PupilId_EduDate");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.EduDate)
                    .HasColumnName("edu_date");

                entity.Property(e => e.LessonVolume).HasColumnName("lesson_volume");

                entity.Property(e => e.MarkValue).HasColumnName("mark_value");

                entity.Property(e => e.MarktypeId).HasColumnName("marktype_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_S_Activities");

                entity.HasOne(d => d.Marktype)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.MarktypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_C_MarkTypes");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationStudyingSpecialMark)
                    .HasForeignKey<FEducationStudyingSpecialMark>(d => d.Id)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_F");
            });

            modelBuilder.Entity<FEducationTeaching>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Education_Teaching");

                entity.HasIndex(e => new { e.DtStart, e.ActivityId })
                    .HasName("IX_F_Education_Teaching_ActivityId_DtStart");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.Essay)
                    .HasColumnName("essay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtragroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.Homework)
                    .IsRequired()
                    .HasColumnName("homework")
                    .HasMaxLength(500);

                entity.Property(e => e.LessonLength).HasColumnName("lesson_length");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Teaching_S_Activities");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.ExtragroupId)
                    .HasConstraintName("FK_F_Education_Teaching_F_Groups_Extra_Items");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Education_Teaching_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationTeaching)
                    .HasForeignKey<FEducationTeaching>(d => d.Id)
                    .HasConstraintName("FK_F_Education_Teaching_F");
            });

            modelBuilder.Entity<FExpertStudyProgram>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Experts_StudyProgram");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ExpertId).HasColumnName("expert_id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.IsActual).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FExpertsStudyProgram)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Experts_StudyProgram_S_Activities");

                entity.HasOne(d => d.Expert)
                    .WithMany(p => p.FExpertsStudyProgram)
                    .HasForeignKey(d => d.ExpertId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Experts_StudyProgram_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FExpertStudyProgram)
                    .HasForeignKey<FExpertStudyProgram>(d => d.Id)
                    .HasConstraintName("FK_F_Experts_StudyProgram_F");
            });

            modelBuilder.Entity<FGroupBasicSostav>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Groups_Basic_Sostav");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FGroupsBasicSostav)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Groups_Basic_Sostav_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FGroupBasicSostav)
                    .HasForeignKey<FGroupBasicSostav>(d => d.Id)
                    .HasConstraintName("FK_F_Groups_Basic_Sostav_F");
            });

            modelBuilder.Entity<FGroupExtra>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Groups_Extra");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasMaxLength(500);

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FGroupExtra)
                    .HasForeignKey<FGroupExtra>(d => d.Id)
                    .HasConstraintName("FK_F_Groups_Extra_F");
            });

            modelBuilder.Entity<FGroupExtraItem>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Groups_Extra_Items");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FGroupsExtraItems)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_Groups_Extra_Items_F_Groups_Extra");
            });

            modelBuilder.Entity<FGroupExtraSostav>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Groups_Extra_Sostav");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FGroupsExtraSostav)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_F_Groups_Extra_Sostav_F_Groups_Extra_Items");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FGroupsExtraSostav)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Groups_Extra_Sostav_Users");
            });

            modelBuilder.Entity<FGroupExtraSource>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Groups_Extra_Sources");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FGroupsExtraSources)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_Groups_Extra_Sources_F_Groups_Extra");
            });

            modelBuilder.Entity<FStudyJob>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyJobs");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.ExtraGroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.MetodistId).HasColumnName("metodist_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyJobs)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyJobs_S_Activities");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FStudyJobs)
                    .HasForeignKey(d => d.ExtraGroupId)
                    .HasConstraintName("FK_F_StudyJobs_F_Groups_Extra_Items");

                entity.HasOne(d => d.Metodist)
                    .WithMany(p => p.FStudyJobsMetodist)
                    .HasForeignKey(d => d.MetodistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyJobs_Users1");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FStudyJobsTeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyJobs_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyJob)
                    .HasForeignKey<FStudyJob>(d => d.Id)
                    .HasConstraintName("FK_F_StudyJobs_F");
            });

            modelBuilder.Entity<FStudyPlan>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPlans");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.PeriodId).HasColumnName("period_id");

                entity.Property(e => e.PlanEnd)
                    .HasColumnName("plan_end");

                entity.Property(e => e.PlanStart)
                    .HasColumnName("plan_start");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FStudyPlans)
                    .HasForeignKey(d => d.PeriodId)
                    .HasConstraintName("FK_F_StudyPlans_C_PeriodTypes");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyPlan)
                    .HasForeignKey<FStudyPlan>(d => d.Id)
                    .HasConstraintName("FK_F_StudyPlans_F");
            });

            modelBuilder.Entity<FStudyPlanContent>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPlans_Content");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyPlansContent)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyPlans_Content_S_Activities");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansContent)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Content_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyPlanNagruzka>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPlans_Nagruzka");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansNagruzka)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Nagruzka_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyPlanRecepient>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPlans_Recepients");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansRecepients)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Recepients_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyProgram>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPrograms");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.EssayCount).HasColumnName("essay_count");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyPrograms)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyPrograms_S_Activities");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyProgram)
                    .HasForeignKey<FStudyProgram>(d => d.Id)
                    .HasConstraintName("FK_F_StudyPrograms_F");
            });

            modelBuilder.Entity<FStudyProgramContent>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPrograms_Content");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.OptId).HasColumnName("opt_id");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FStudyProgramsContent)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_StudyPrograms_Content_F_StudyPrograms");

                entity.HasOne(d => d.Opt)
                    .WithMany(p => p.FStudyProgramsContent)
                    .HasForeignKey(d => d.OptId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudyPrograms_Content_S_OPT");
            });

            modelBuilder.Entity<FStudyProgramRecepient>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudyPrograms_Recepients");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.ExtraGroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.HasOne(d => d.ExtraGroup)
                    .WithMany(p => p.FStudyProgramsRecepients)
                    .HasForeignKey(d => d.ExtraGroupId)
                    .HasConstraintName("FK_F_StudyPrograms_Recepients_F_Groups_Extra_Items");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FStudyProgramsRecepients)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_StudyPrograms_Recepients_F_StudyPrograms");
            });

            modelBuilder.Entity<FStudySchedule>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_StudySchedule");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicGroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.ClassroomId).HasColumnName("classroom_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.ExtraGroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudySchedule_S_Activities");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ClassroomId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_StudySchedule_S_Classrooms");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ExtraGroupId)
                    .HasConstraintName("FK_F_StudySchedule_F_Groups_Extra_Items");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_F_StudySchedule_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudySchedule)
                    .HasForeignKey<FStudySchedule>(d => d.Id)
                    .HasConstraintName("FK_F_StudySchedule_F");
            });

            modelBuilder.Entity<FWorker>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Workers");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.IsTeacher).HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.StavkaNorma).HasColumnName("stavka_norma");

                entity.Property(e => e.StavkaValue).HasColumnName("stavka_value");

                entity.Property(e => e.WorkerId).HasColumnName("worker_id");

                entity.Property(e => e.WorkTypeId).HasColumnName("worktype_id");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_F_Workers_C_EducationTypes");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_S_Positions");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FWorker)
                    .HasForeignKey<FWorker>(d => d.Id)
                    .HasConstraintName("FK_F_Workers_F");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_Users");

                entity.HasOne(d => d.Worktype)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_C_WorkTypes");
            });

            modelBuilder.Entity<FWorkerTeaching>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("F_Workers_Teaching");

                entity.Property(e => e.Id)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_Teaching_S_Activities");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_Teaching_C_WorkCategories");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_F_Workers_Teaching_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FWorkerTeaching)
                    .HasForeignKey<FWorkerTeaching>(d => d.Id)
                    .HasConstraintName("FK_F_Workers_Teaching_F");
            });

            modelBuilder.Entity<SActivity>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("S_Activities");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr);

                entity.Property(e => e.HasMainMarks).HasDefaultValueSql("((1))");

                entity.Property(e => e.HasSpecialMarks).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAbstract).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SActivities)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_S_Activities_C_ActivityTypes");
            });

            modelBuilder.Entity<SClassroom>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("S_Classrooms");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShareable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<SiteDocument>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("SiteDocuments");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<SOpt>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("S_OPT");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.Grades)
                    .HasColumnName("grades")
                    .HasColumnType("shortstring")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFrozen).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShareable).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadingFormUd)
                    .HasColumnName("LeadingFormUD")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OrgForm).HasMaxLength(500);

                entity.Property(e => e.Result);

                entity.Property(e => e.SimpleKim)
                    .HasColumnName("SimpleKIM");

                entity.Property(e => e.SimpleResources);

                entity.Property(e => e.TargetDeveloping)
                    .HasColumnName("Target_Developing");

                entity.Property(e => e.TargetStudy)
                    .HasColumnName("Target_Study");

                entity.Property(e => e.TargetTeaching)
                    .HasColumnName("Target_Teaching");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_S_OPT_S_Activities");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_S_OPT_Users");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_S_OPT_A_Objects");
            });

            modelBuilder.Entity<SOrganization>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("S_Organizations");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpravName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SPosition>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("S_Positions");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr);

                entity.Property(e => e.FullName).HasMaxLength(500);

                entity.Property(e => e.GroupIndex).HasColumnName("group_index");

                entity.Property(e => e.IsAbstract).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<IsusUser>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Users");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountPwd)
                    .HasColumnName("account_pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountPwdMd5)
                    .HasColumnName("account_pwd_md5")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountValid)
                    .HasColumnName("account_valid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactInfo).HasMaxLength(500);

                entity.Property(e => e.CurrentName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CurrentShortName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBoss).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeveloper).HasDefaultValueSql("((0))");

                entity.Property(e => e.SurplusIsTeacher)
                    .HasColumnName("surplus_IsTeacher")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SurplusKlassId).HasColumnName("surplus_klass_id");

                entity.Property(e => e.Tmp).HasColumnName("tmp");
            });

            modelBuilder.Entity<UserOrganizer>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Users_Organizer");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(500);

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserParentship>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Users_Parentship");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.ChildId).HasColumnName("child_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.RoleDescr)
                    .HasColumnName("role_descr")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.UsersParentshipChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Users_Parentship_Users1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.UsersParentshipParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Users_Parentship_Users");
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.HasKey(e => e.Session);

                entity.ToTable("Users_Sessions");

                entity.HasIndex(e => e.Session)
                    .HasName("IX_Users_Sessions")
                    .IsUnique();

                entity.Property(e => e.Session)
                    .HasColumnName("session")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.IsusUser)
                    .WithMany(p => p.UsersSessions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Users_Sessions_Users");
            });

            modelBuilder.Entity<WorkYearItem>(entity =>
            {
                entity.HasKey(e => e.WorkYear);

                entity.ToTable("WorkYears");

                entity.Property(e => e.WorkYear).ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start");

                entity.Property(e => e.GradeMax).HasColumnName("grade_max");

                entity.Property(e => e.GradeMin).HasColumnName("grade_min");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WorkYearGroupBasic>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("WorkYears_Groups_Basic");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.Descr).HasMaxLength(500);

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.WorkYearItemNavigation)
                    .WithMany(p => p.WorkYearsGroupsBasic)
                    .HasForeignKey(d => d.WorkYear)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkYears_Groups_Basic_WorkYears");
            });

            modelBuilder.Entity<WorkYearMarkType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("WorkYears_MarkTypes");

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.IsIntegral).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarkTypeId).HasColumnName("marktype_id");

                entity.HasOne(d => d.MarkType)
                    .WithMany(p => p.WorkYearsMarkTypes)
                    .HasForeignKey(d => d.MarkTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkYears_MarkTypes_C_MarkTypes");

                entity.HasOne(d => d.WorkYearItemNavigation)
                    .WithMany(p => p.WorkYearsMarkTypes)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_WorkYears_MarkTypes_WorkYears");
            });

            modelBuilder.Entity<WorkYearMarkTypeValue>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("WorkYears_MarkTypes_Values");

                entity.HasIndex(e => new { WorkyearMarktypeId = e.WorkYearMarkTypeId, e.ValueInt })
                    .HasName("IX_WorkYears_MarkTypes_Values")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("uid");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValueInt).HasColumnName("value_int");

                entity.Property(e => e.ValueStr)
                    .IsRequired()
                    .HasColumnName("value_str")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkYearMarkTypeId).HasColumnName("workyear_marktype_id");

                entity.HasOne(d => d.WorkyearMarktype)
                    .WithMany(p => p.WorkYearsMarkTypesValues)
                    .HasForeignKey(d => d.WorkYearMarkTypeId)
                    .HasConstraintName("FK_WorkYears_MarkTypes_Values_WorkYears_MarkTypes");
            });
        }
    }
}
