using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Isus2017DataModel
{
    public partial class ISUSContext : DbContext
    {
        public virtual DbSet<AbpAuditLogs> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJobs> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpEditions> AbpEditions { get; set; }
        public virtual DbSet<AbpFeatures> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguages> AbpLanguages { get; set; }
        public virtual DbSet<AbpLanguageTexts> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpNotifications> AbpNotifications { get; set; }
        public virtual DbSet<AbpNotificationSubscriptions> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpOrganizationUnits> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpPermissions> AbpPermissions { get; set; }
        public virtual DbSet<AbpRoles> AbpRoles { get; set; }
        public virtual DbSet<AbpSettings> AbpSettings { get; set; }
        public virtual DbSet<AbpTenantNotifications> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpTenants> AbpTenants { get; set; }
        public virtual DbSet<AbpUserAccounts> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserLoginAttempts> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserNotifications> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnits> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUsers> AbpUsers { get; set; }
        public virtual DbSet<AObjects> AObjects { get; set; }
        public virtual DbSet<AObjectsEz> AObjectsEz { get; set; }
        public virtual DbSet<AObjectsValidation> AObjectsValidation { get; set; }
        public virtual DbSet<AObjectsValidationResults> AObjectsValidationResults { get; set; }
        public virtual DbSet<AObjectTypes> AObjectTypes { get; set; }
        public virtual DbSet<AObjectTypesJournals> AObjectTypesJournals { get; set; }
        public virtual DbSet<AObjectTypesPermissions> AObjectTypesPermissions { get; set; }
        public virtual DbSet<ATasks> ATasks { get; set; }
        public virtual DbSet<AVariables> AVariables { get; set; }
        public virtual DbSet<CActivityTypes> CActivityTypes { get; set; }
        public virtual DbSet<CDivisions> CDivisions { get; set; }
        public virtual DbSet<CEducationTypes> CEducationTypes { get; set; }
        public virtual DbSet<CMarkTypes> CMarkTypes { get; set; }
        public virtual DbSet<CObjectStates> CObjectStates { get; set; }
        public virtual DbSet<CPeriodTypes> CPeriodTypes { get; set; }
        public virtual DbSet<CWorkCategories> CWorkCategories { get; set; }
        public virtual DbSet<CWorkTypes> CWorkTypes { get; set; }
        public virtual DbSet<F> F { get; set; }
        public virtual DbSet<FEducationCud> FEducationCud { get; set; }
        public virtual DbSet<FEducationCudMarks> FEducationCudMarks { get; set; }
        public virtual DbSet<FEducationResults> FEducationResults { get; set; }
        public virtual DbSet<FEducationResultsFinal> FEducationResultsFinal { get; set; }
        public virtual DbSet<FEducationStudyingMainMarks> FEducationStudyingMainMarks { get; set; }
        public virtual DbSet<FEducationStudyingSpecialMarks> FEducationStudyingSpecialMarks { get; set; }
        public virtual DbSet<FEducationTeaching> FEducationTeaching { get; set; }
        public virtual DbSet<FExpertsStudyProgram> FExpertsStudyProgram { get; set; }
        public virtual DbSet<FGroupsBasicSostav> FGroupsBasicSostav { get; set; }
        public virtual DbSet<FGroupsExtra> FGroupsExtra { get; set; }
        public virtual DbSet<FGroupsExtraItems> FGroupsExtraItems { get; set; }
        public virtual DbSet<FGroupsExtraSostav> FGroupsExtraSostav { get; set; }
        public virtual DbSet<FGroupsExtraSources> FGroupsExtraSources { get; set; }
        public virtual DbSet<FStudyJobs> FStudyJobs { get; set; }
        public virtual DbSet<FStudyPlans> FStudyPlans { get; set; }
        public virtual DbSet<FStudyPlansContent> FStudyPlansContent { get; set; }
        public virtual DbSet<FStudyPlansNagruzka> FStudyPlansNagruzka { get; set; }
        public virtual DbSet<FStudyPlansRecepients> FStudyPlansRecepients { get; set; }
        public virtual DbSet<FStudyPrograms> FStudyPrograms { get; set; }
        public virtual DbSet<FStudyProgramsContent> FStudyProgramsContent { get; set; }
        public virtual DbSet<FStudyProgramsRecepients> FStudyProgramsRecepients { get; set; }
        public virtual DbSet<FStudySchedule> FStudySchedule { get; set; }
        public virtual DbSet<FWorkers> FWorkers { get; set; }
        public virtual DbSet<FWorkersTeaching> FWorkersTeaching { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<SActivities> SActivities { get; set; }
        public virtual DbSet<SClassrooms> SClassrooms { get; set; }
        public virtual DbSet<SiteDocuments> SiteDocuments { get; set; }
        public virtual DbSet<SOpt> SOpt { get; set; }
        public virtual DbSet<SOrganizations> SOrganizations { get; set; }
        public virtual DbSet<SPositions> SPositions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersOrganizer> UsersOrganizer { get; set; }
        public virtual DbSet<UsersParentship> UsersParentship { get; set; }
        public virtual DbSet<UsersSessions> UsersSessions { get; set; }
        public virtual DbSet<WorkYears> WorkYears { get; set; }
        public virtual DbSet<WorkYearsGroupsBasic> WorkYearsGroupsBasic { get; set; }
        public virtual DbSet<WorkYearsMarkTypes> WorkYearsMarkTypes { get; set; }
        public virtual DbSet<WorkYearsMarkTypesValues> WorkYearsMarkTypesValues { get; set; }
        public virtual DbSet<ZwastedWorkYearsGroupsExtra> ZwastedWorkYearsGroupsExtra { get; set; }
        public virtual DbSet<ZwastedWorkYearsGroupsExtraItems> ZwastedWorkYearsGroupsExtraItems { get; set; }
        public virtual DbSet<ZwastedWorkYearsGroupsExtraSets> ZwastedWorkYearsGroupsExtraSets { get; set; }
        public virtual DbSet<ZwastedWorkYearsGroupsExtraSetsSources> ZwastedWorkYearsGroupsExtraSetsSources { get; set; }
        public virtual DbSet<ZwastedWorkYearsGroupsExtraSources> ZwastedWorkYearsGroupsExtraSources { get; set; }
        public virtual DbSet<ZwastedZWorkYearsGroupsExtra> ZwastedZWorkYearsGroupsExtra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"data source=.\sqlexpress2012;initial catalog=ISUS;integrated security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbpAuditLogs>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime })
                    .HasName("IX_TenantId_ExecutionTime");

                entity.HasIndex(e => new { e.UserId, e.ExecutionTime })
                    .HasName("IX_UserId_ExecutionTime");

                entity.Property(e => e.BrowserInfo).HasMaxLength(256);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.ExecutionTime).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJobs>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime })
                    .HasName("IX_IsAbandoned_NextTryTime");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.LastTryTime).HasColumnType("datetime");

                entity.Property(e => e.NextTryTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpEditions>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AbpFeatures>(entity =>
            {
                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_TenantId_Name");

                entity.HasIndex(e => new { e.Discriminator, e.EditionId, e.Name })
                    .HasName("IX_Discriminator_EditionId_Name");

                entity.HasIndex(e => new { e.Discriminator, e.TenantId, e.Name })
                    .HasName("IX_Discriminator_TenantId_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpFeatures_dbo.AbpEditions_EditionId");
            });

            modelBuilder.Entity<AbpLanguages>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_TenantId_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AbpLanguageTexts>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.LanguageName, e.Source, e.Key })
                    .HasName("IX_TenantId_LanguageName_Source_Key");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotificationSubscriptions>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId })
                    .HasName("IX_NotificationName_EntityTypeName_EntityId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnits>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.HasIndex(e => new { e.TenantId, e.Code })
                    .HasName("IX_TenantId_Code");

                entity.HasIndex(e => new { e.TenantId, e.ParentId })
                    .HasName("IX_TenantId_ParentId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.AbpOrganizationUnits_dbo.AbpOrganizationUnits_ParentId");
            });

            modelBuilder.Entity<AbpPermissions>(entity =>
            {
                entity.HasIndex(e => new { e.RoleId, e.Name })
                    .HasName("IX_RoleId_Name");

                entity.HasIndex(e => new { e.UserId, e.Name })
                    .HasName("IX_UserId_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpPermissions_dbo.AbpRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpPermissions_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpRoles>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_TenantId_Name");

                entity.HasIndex(e => new { e.IsDeleted, e.TenantId, e.Name })
                    .HasName("IX_IsDeleted_TenantId_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRolesCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRolesDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRolesLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<AbpSettings>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name })
                    .HasName("IX_TenantId_Name");

                entity.HasIndex(e => new { e.UserId, e.Name })
                    .HasName("IX_UserId_Name");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpSettings_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpTenantNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpTenants>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.HasIndex(e => e.TenancyName)
                    .HasName("IX_TenancyName");

                entity.HasIndex(e => new { e.IsDeleted, e.TenancyName })
                    .HasName("IX_IsDeleted_TenancyName");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantsCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantsDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpEditions_EditionId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantsLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<AbpUserAccounts>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserLoginAttempts>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.TenantId })
                    .HasName("IX_UserId_TenantId");

                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result })
                    .HasName("IX_TenancyName_UserNameOrEmailAddress_Result");

                entity.Property(e => e.BrowserInfo).HasMaxLength(256);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<AbpUserLogins>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.LoginProvider })
                    .HasName("IX_UserId_LoginProvider");

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpUserLogins_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpUserNotifications>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime })
                    .HasName("IX_UserId_State_CreationTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserOrganizationUnits>(entity =>
            {
                entity.HasIndex(e => e.OrganizationUnitId)
                    .HasName("IX_OrganizationUnitId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId })
                    .HasName("IX_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.UserId })
                    .HasName("IX_TenantId_UserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserRoles>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("IX_UserId_RoleId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpUserRoles_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpUsers>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.EmailAddress })
                    .HasName("IX_TenantId_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.UserName })
                    .HasName("IX_TenantId_UserName");

                entity.HasIndex(e => new { e.IsDeleted, e.TenantId, e.EmailAddress })
                    .HasName("IX_IsDeleted_TenantId_EmailAddress");

                entity.HasIndex(e => new { e.IsDeleted, e.TenantId, e.UserName })
                    .HasName("IX_IsDeleted_TenantId_UserName");

                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(128);

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<AObjects>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Objects");

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocNum)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.DocNumInt).HasColumnName("DocNum_Int");

                entity.Property(e => e.ExpertId).HasColumnName("expert_id");

                entity.Property(e => e.FirstProjectDate).HasColumnType("datetime");

                entity.Property(e => e.IsAutoNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmpty).HasDefaultValueSql("((1))");

                entity.Property(e => e.LockerSession)
                    .HasColumnName("locker_session")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectstateId).HasColumnName("objectstate_id");

                entity.Property(e => e.ObjectypeId).HasColumnName("objectype_id");

                entity.Property(e => e.OrgId).HasColumnName("org_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AObjectsAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_A_Objects_Users2");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.AObjectsCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
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

                entity.HasOne(d => d.Objectstate)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.ObjectstateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Objects_C_ObjectStates");

                entity.HasOne(d => d.Objectype)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.ObjectypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Objects_A_ObjectTypes");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_A_Objects_S_Organizations");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.AObjects)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_A_Objects_WorkYears");
            });

            modelBuilder.Entity<AObjectsEz>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Objects_EZ");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.EzContent)
                    .IsRequired()
                    .HasColumnName("ez_content")
                    .HasColumnType("string");

                entity.Property(e => e.EzData)
                    .IsRequired()
                    .HasColumnName("ez_data")
                    .HasColumnType("xml");

                entity.Property(e => e.EzDate)
                    .HasColumnName("ez_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EzSigma)
                    .HasColumnName("ez_sigma")
                    .HasColumnType("string");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.AObjectsEz)
                    .HasForeignKey(d => d.ObjectId)
                    .HasConstraintName("FK_A_Objects_EZ_A_Objects");
            });

            modelBuilder.Entity<AObjectsValidation>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Objects_Validation");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectstateId).HasColumnName("objectstate_id");

                entity.Property(e => e.Session)
                    .IsRequired()
                    .HasColumnName("session")
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.Objectstate)
                    .WithMany(p => p.AObjectsValidation)
                    .HasForeignKey(d => d.ObjectstateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Objects_Validation_C_ObjectStates");

                entity.HasOne(d => d.SessionNavigation)
                    .WithMany(p => p.AObjectsValidation)
                    .HasForeignKey(d => d.Session)
                    .HasConstraintName("FK_A_Objects_Validation_Users_Sessions");
            });

            modelBuilder.Entity<AObjectsValidationResults>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Objects_Validation_Results");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("littera")
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnName("descr")
                    .HasColumnType("string");

                entity.Property(e => e.ValidationId).HasColumnName("validation_id");

                entity.HasOne(d => d.Validation)
                    .WithMany(p => p.AObjectsValidationResults)
                    .HasForeignKey(d => d.ValidationId)
                    .HasConstraintName("FK_A_Objects_Validation_Results_A_Objects_Validation");
            });

            modelBuilder.Entity<AObjectTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_ObjectTypes");

                entity.HasIndex(e => e.Label)
                    .HasName("uc_Label")
                    .IsUnique();

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoAffirm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("littera");

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
                    .HasColumnType("shortstring");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PermissionMask).HasDefaultValueSql("((11))");

                entity.Property(e => e.ProcContentor).HasColumnType("string");

                entity.Property(e => e.ProcDataLoader).HasColumnType("string");

                entity.Property(e => e.ProcPoster).HasColumnType("string");

                entity.Property(e => e.ProcSaveTrigger).HasColumnType("string");

                entity.Property(e => e.ProcValidator).HasColumnType("string");

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

            modelBuilder.Entity<AObjectTypesJournals>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_ObjectTypes_Journals");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.Postfix)
                    .IsRequired()
                    .HasColumnName("postfix")
                    .HasColumnType("shortstring")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasColumnType("shortstring")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResetMonth).HasColumnName("reset_month");
            });

            modelBuilder.Entity<AObjectTypesPermissions>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_ObjectTypes_Permissions");

                entity.HasIndex(e => new { e.ObjectypeId, e.UserId })
                    .HasName("IX_A_ObjectTypes_Permissions")
                    .IsUnique();

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.ObjectypeId).HasColumnName("objectype_id");

                entity.Property(e => e.Permissions).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Objectype)
                    .WithMany(p => p.AObjectTypesPermissions)
                    .HasForeignKey(d => d.ObjectypeId)
                    .HasConstraintName("FK_A_ObjectTypes_Permissions_A_ObjectTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AObjectTypesPermissions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_A_ObjectTypes_Permissions_Users");
            });

            modelBuilder.Entity<ATasks>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Tasks");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.Failtime)
                    .HasColumnName("failtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.HookedObjectId).HasColumnName("hooked_object_id");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.PausedObjectId).HasColumnName("paused_object_id");

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.Showtime)
                    .HasColumnName("showtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Txt).HasColumnType("string");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Tasks_Users1");
            });

            modelBuilder.Entity<AVariables>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("A_Variables");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.ValueBinary).HasColumnName("value_binary");

                entity.Property(e => e.ValueBit).HasColumnName("value_bit");

                entity.Property(e => e.ValueDatetime)
                    .HasColumnName("value_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValueInt).HasColumnName("value_int");

                entity.Property(e => e.ValueStr)
                    .HasColumnName("value_str")
                    .HasColumnType("string");

                entity.Property(e => e.ValueXml)
                    .HasColumnName("value_xml")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<CActivityTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_ActivityTypes");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CDivisions>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_Divisions");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("label");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CEducationTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_EducationTypes");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CMarkTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_MarkTypes");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CObjectStates>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_ObjectStates");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CPeriodTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_PeriodTypes");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.PeriodGroup)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CWorkCategories>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_WorkCategories");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<CWorkTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("C_WorkTypes");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<F>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectIdOut).HasColumnName("object_id_out");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.FObject)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_A_Objects");

                entity.HasOne(d => d.ObjectIdOutNavigation)
                    .WithMany(p => p.FObjectIdOutNavigation)
                    .HasForeignKey(d => d.ObjectIdOut)
                    .HasConstraintName("FK_F_A_Objects1");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.F)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_F_WorkYears");
            });

            modelBuilder.Entity<FEducationCud>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_CUD");

                entity.HasIndex(e => new { e.Uid, e.ActivityId, e.ProgOptId, e.CudText, e.PupilId })
                    .HasName("IX_FEducationCUD_PupilId");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CudText)
                    .HasColumnName("cud_text")
                    .HasColumnType("comments");

                entity.Property(e => e.ProgOptId).HasColumnName("prog_opt_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_CUD_S_Activities");

                entity.HasOne(d => d.ProgOpt)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.ProgOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_CUD_F_StudyPrograms_Content");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationCud)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_CUD_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationCud)
                    .HasForeignKey<FEducationCud>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_CUD_F");
            });

            modelBuilder.Entity<FEducationCudMarks>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_CUD_Marks");

                entity.HasIndex(e => new { e.MarktypeId, e.MarkValue, e.FactId })
                    .HasName("IX_FEducationCUDMarks_FactId");

                entity.Property(e => e.Uid).HasColumnName("uid");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_CUD_Marks_C_MarkTypes");
            });

            modelBuilder.Entity<FEducationResults>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_Results");

                entity.HasIndex(e => new { e.PupilId, e.ActivityId, e.PeriodId })
                    .HasName("IX_F_Education_Results")
                    .IsUnique();

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.MarkMain).HasColumnName("mark_main");

                entity.Property(e => e.PeriodId).HasColumnName("period_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Results_S_Activities");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Results_C_PeriodTypes");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_Education_Results_F_StudyPlans");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationResults)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Results_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationResults)
                    .HasForeignKey<FEducationResults>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_Results_F");
            });

            modelBuilder.Entity<FEducationResultsFinal>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_Results_Final");

                entity.Property(e => e.Uid)
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Results_Final_S_Activities");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationResultsFinal)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Results_Final_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationResultsFinal)
                    .HasForeignKey<FEducationResultsFinal>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_Results_Final_F");
            });

            modelBuilder.Entity<FEducationStudyingMainMarks>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_Studying_MainMarks");

                entity.HasIndex(e => new { e.PupilId, e.IsAbsent, e.DtStart })
                    .HasName("IX_Education_Studying_MainMarks_PupilId_IsAbsent_DtStart");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.LessonLength).HasColumnName("lesson_length");

                entity.Property(e => e.MarkType)
                    .IsRequired()
                    .HasColumnName("mark_type")
                    .HasColumnType("shortstring");

                entity.Property(e => e.MarkValue).HasColumnName("mark_value");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.Property(e => e.TimeLate)
                    .HasColumnName("time_late")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationStudyingMainMarks)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_S_Activities");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationStudyingMainMarks)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationStudyingMainMarks)
                    .HasForeignKey<FEducationStudyingMainMarks>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_Studying_MainMarks_F");
            });

            modelBuilder.Entity<FEducationStudyingSpecialMarks>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_Studying_SpecialMarks");

                entity.HasIndex(e => new { e.LessonVolume, e.ActivityId, e.MarktypeId, e.MarkValue, e.PupilId, e.EduDate })
                    .HasName("IX_FEducationStudyingSpecialMarks_PupilId_EduDate");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.EduDate)
                    .HasColumnName("edu_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LessonVolume).HasColumnName("lesson_volume");

                entity.Property(e => e.MarkValue).HasColumnName("mark_value");

                entity.Property(e => e.MarktypeId).HasColumnName("marktype_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_S_Activities");

                entity.HasOne(d => d.Marktype)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.MarktypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_C_MarkTypes");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationStudyingSpecialMarks)
                    .HasForeignKey<FEducationStudyingSpecialMarks>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_Studying_SpecialMarks_F");
            });

            modelBuilder.Entity<FEducationTeaching>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Education_Teaching");

                entity.HasIndex(e => new { e.DtStart, e.ActivityId })
                    .HasName("IX_F_Education_Teaching_ActivityId_DtStart");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Essay)
                    .HasColumnName("essay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtragroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.Homework)
                    .IsRequired()
                    .HasColumnName("homework")
                    .HasColumnType("string");

                entity.Property(e => e.LessonLength).HasColumnName("lesson_length");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasColumnType("string");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Teaching_S_Activities");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.ExtragroupId)
                    .HasConstraintName("FK_F_Education_Teaching_F_Groups_Extra_Items");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FEducationTeaching)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Education_Teaching_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FEducationTeaching)
                    .HasForeignKey<FEducationTeaching>(d => d.Uid)
                    .HasConstraintName("FK_F_Education_Teaching_F");
            });

            modelBuilder.Entity<FExpertsStudyProgram>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Experts_StudyProgram");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ExpertId).HasColumnName("expert_id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.IsActual).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FExpertsStudyProgram)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Experts_StudyProgram_S_Activities");

                entity.HasOne(d => d.Expert)
                    .WithMany(p => p.FExpertsStudyProgram)
                    .HasForeignKey(d => d.ExpertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Experts_StudyProgram_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FExpertsStudyProgram)
                    .HasForeignKey<FExpertsStudyProgram>(d => d.Uid)
                    .HasConstraintName("FK_F_Experts_StudyProgram_F");
            });

            modelBuilder.Entity<FGroupsBasicSostav>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Groups_Basic_Sostav");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FGroupsBasicSostav)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Groups_Basic_Sostav_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FGroupsBasicSostav)
                    .HasForeignKey<FGroupsBasicSostav>(d => d.Uid)
                    .HasConstraintName("FK_F_Groups_Basic_Sostav_F");
            });

            modelBuilder.Entity<FGroupsExtra>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Groups_Extra");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FGroupsExtra)
                    .HasForeignKey<FGroupsExtra>(d => d.Uid)
                    .HasConstraintName("FK_F_Groups_Extra_F");
            });

            modelBuilder.Entity<FGroupsExtraItems>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Groups_Extra_Items");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FGroupsExtraItems)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_Groups_Extra_Items_F_Groups_Extra");
            });

            modelBuilder.Entity<FGroupsExtraSostav>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Groups_Extra_Sostav");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PupilId).HasColumnName("pupil_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FGroupsExtraSostav)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_F_Groups_Extra_Sostav_F_Groups_Extra_Items");

                entity.HasOne(d => d.Pupil)
                    .WithMany(p => p.FGroupsExtraSostav)
                    .HasForeignKey(d => d.PupilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Groups_Extra_Sostav_Users");
            });

            modelBuilder.Entity<FGroupsExtraSources>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Groups_Extra_Sources");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FGroupsExtraSources)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_Groups_Extra_Sources_F_Groups_Extra");
            });

            modelBuilder.Entity<FStudyJobs>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyJobs");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtragroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.MetodistId).HasColumnName("metodist_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyJobs)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyJobs_S_Activities");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FStudyJobs)
                    .HasForeignKey(d => d.ExtragroupId)
                    .HasConstraintName("FK_F_StudyJobs_F_Groups_Extra_Items");

                entity.HasOne(d => d.Metodist)
                    .WithMany(p => p.FStudyJobsMetodist)
                    .HasForeignKey(d => d.MetodistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyJobs_Users1");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FStudyJobsTeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyJobs_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyJobs)
                    .HasForeignKey<FStudyJobs>(d => d.Uid)
                    .HasConstraintName("FK_F_StudyJobs_F");
            });

            modelBuilder.Entity<FStudyPlans>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPlans");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.PeriodId).HasColumnName("period_id");

                entity.Property(e => e.PlanEnd)
                    .HasColumnName("plan_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanStart)
                    .HasColumnName("plan_start")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FStudyPlans)
                    .HasForeignKey(d => d.PeriodId)
                    .HasConstraintName("FK_F_StudyPlans_C_PeriodTypes");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyPlans)
                    .HasForeignKey<FStudyPlans>(d => d.Uid)
                    .HasConstraintName("FK_F_StudyPlans_F");
            });

            modelBuilder.Entity<FStudyPlansContent>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPlans_Content");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyPlansContent)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyPlans_Content_S_Activities");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansContent)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Content_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyPlansNagruzka>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPlans_Nagruzka");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansNagruzka)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Nagruzka_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyPlansRecepients>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPlans_Recepients");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.FStudyPlansRecepients)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_F_StudyPlans_Recepients_F_StudyPlans");
            });

            modelBuilder.Entity<FStudyPrograms>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPrograms");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssayCount).HasColumnName("essay_count");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudyPrograms)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyPrograms_S_Activities");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudyPrograms)
                    .HasForeignKey<FStudyPrograms>(d => d.Uid)
                    .HasConstraintName("FK_F_StudyPrograms_F");
            });

            modelBuilder.Entity<FStudyProgramsContent>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPrograms_Content");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.Property(e => e.OptId).HasColumnName("opt_id");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FStudyProgramsContent)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_StudyPrograms_Content_F_StudyPrograms");

                entity.HasOne(d => d.Opt)
                    .WithMany(p => p.FStudyProgramsContent)
                    .HasForeignKey(d => d.OptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudyPrograms_Content_S_OPT");
            });

            modelBuilder.Entity<FStudyProgramsRecepients>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudyPrograms_Recepients");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.ExtragroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.FactId).HasColumnName("fact_id");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FStudyProgramsRecepients)
                    .HasForeignKey(d => d.ExtragroupId)
                    .HasConstraintName("FK_F_StudyPrograms_Recepients_F_Groups_Extra_Items");

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.FStudyProgramsRecepients)
                    .HasForeignKey(d => d.FactId)
                    .HasConstraintName("FK_F_StudyPrograms_Recepients_F_StudyPrograms");
            });

            modelBuilder.Entity<FStudySchedule>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_StudySchedule");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.ClassroomId).HasColumnName("classroom_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtragroupId).HasColumnName("extragroup_id");

                entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudySchedule_S_Activities");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_StudySchedule_S_Classrooms");

                entity.HasOne(d => d.Extragroup)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.ExtragroupId)
                    .HasConstraintName("FK_F_StudySchedule_F_Groups_Extra_Items");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FStudySchedule)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_F_StudySchedule_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FStudySchedule)
                    .HasForeignKey<FStudySchedule>(d => d.Uid)
                    .HasConstraintName("FK_F_StudySchedule_F");
            });

            modelBuilder.Entity<FWorkers>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Workers");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.IsTeacher).HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.StavkaNorma).HasColumnName("stavka_norma");

                entity.Property(e => e.StavkaValue).HasColumnName("stavka_value");

                entity.Property(e => e.WorkerId).HasColumnName("worker_id");

                entity.Property(e => e.WorktypeId).HasColumnName("worktype_id");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_F_Workers_C_EducationTypes");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_S_Positions");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FWorkers)
                    .HasForeignKey<FWorkers>(d => d.Uid)
                    .HasConstraintName("FK_F_Workers_F");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_Users");

                entity.HasOne(d => d.Worktype)
                    .WithMany(p => p.FWorkers)
                    .HasForeignKey(d => d.WorktypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_C_WorkTypes");
            });

            modelBuilder.Entity<FWorkersTeaching>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("F_Workers_Teaching");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_Teaching_S_Activities");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_Teaching_C_WorkCategories");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.FWorkersTeaching)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_F_Workers_Teaching_Users");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.FWorkersTeaching)
                    .HasForeignKey<FWorkersTeaching>(d => d.Uid)
                    .HasConstraintName("FK_F_Workers_Teaching_F");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SActivities>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("S_Activities");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("comments");

                entity.Property(e => e.HasMainMarks).HasDefaultValueSql("((1))");

                entity.Property(e => e.HasSpecialMarks).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAbstract).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SActivities)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_Activities_C_ActivityTypes");
            });

            modelBuilder.Entity<SClassrooms>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("S_Classrooms");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("comments");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShareable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<SiteDocuments>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<SOpt>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("S_OPT");

                entity.Property(e => e.Uid).HasColumnName("uid");

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
                    .HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.OrgForm).HasColumnType("string");

                entity.Property(e => e.Result).HasColumnType("comments");

                entity.Property(e => e.SimpleKim)
                    .HasColumnName("SimpleKIM")
                    .HasColumnType("comments");

                entity.Property(e => e.SimpleResources).HasColumnType("comments");

                entity.Property(e => e.TargetDeveloping)
                    .HasColumnName("Target_Developing")
                    .HasColumnType("comments");

                entity.Property(e => e.TargetStudy)
                    .HasColumnName("Target_Study")
                    .HasColumnType("comments");

                entity.Property(e => e.TargetTeaching)
                    .HasColumnName("Target_Teaching")
                    .HasColumnType("comments");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_OPT_S_Activities");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_OPT_Users");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.SOpt)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_S_OPT_A_Objects");
            });

            modelBuilder.Entity<SOrganizations>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("S_Organizations");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpravName)
                    .IsRequired()
                    .HasColumnType("shortstring");
            });

            modelBuilder.Entity<SPositions>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("S_Positions");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("comments");

                entity.Property(e => e.FullName).HasColumnType("string");

                entity.Property(e => e.GroupIndex).HasColumnName("group_index");

                entity.Property(e => e.IsAbstract).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasColumnType("shortstring");

                entity.Property(e => e.AccountPwd)
                    .HasColumnName("account_pwd")
                    .HasColumnType("shortstring");

                entity.Property(e => e.AccountPwdMd5)
                    .HasColumnName("account_pwd_md5")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountValid)
                    .HasColumnName("account_valid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactInfo).HasColumnType("string");

                entity.Property(e => e.CurrentName)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.CurrentShortName)
                    .IsRequired()
                    .HasColumnType("string");

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.Property(e => e.Email).HasColumnType("shortstring");

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

            modelBuilder.Entity<UsersOrganizer>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("Users_Organizer");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasColumnType("string");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("shortstring");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersParentship>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("Users_Parentship");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.ChildId).HasColumnName("child_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.RoleDescr)
                    .HasColumnName("role_descr")
                    .HasColumnType("string");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.UsersParentshipChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Parentship_Users1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.UsersParentshipParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Parentship_Users");
            });

            modelBuilder.Entity<UsersSessions>(entity =>
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
                    .HasColumnName("login_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersSessions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Users_Sessions_Users");
            });

            modelBuilder.Entity<WorkYears>(entity =>
            {
                entity.HasKey(e => e.WorkYear);

                entity.Property(e => e.WorkYear).ValueGeneratedNever();

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dt_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dt_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.GradeMax).HasColumnName("grade_max");

                entity.Property(e => e.GradeMin).HasColumnName("grade_min");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WorkYearsGroupsBasic>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("WorkYears_Groups_Basic");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.WorkYearsGroupsBasic)
                    .HasForeignKey(d => d.WorkYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkYears_Groups_Basic_WorkYears");
            });

            modelBuilder.Entity<WorkYearsMarkTypes>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("WorkYears_MarkTypes");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.IsIntegral).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarktypeId).HasColumnName("marktype_id");

                entity.HasOne(d => d.Marktype)
                    .WithMany(p => p.WorkYearsMarkTypes)
                    .HasForeignKey(d => d.MarktypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkYears_MarkTypes_C_MarkTypes");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.WorkYearsMarkTypes)
                    .HasForeignKey(d => d.WorkYear)
                    .HasConstraintName("FK_WorkYears_MarkTypes_WorkYears");
            });

            modelBuilder.Entity<WorkYearsMarkTypesValues>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("WorkYears_MarkTypes_Values");

                entity.HasIndex(e => new { e.WorkyearMarktypeId, e.ValueInt })
                    .HasName("IX_WorkYears_MarkTypes_Values")
                    .IsUnique();

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValueInt).HasColumnName("value_int");

                entity.Property(e => e.ValueStr)
                    .IsRequired()
                    .HasColumnName("value_str")
                    .HasColumnType("shortstring");

                entity.Property(e => e.WorkyearMarktypeId).HasColumnName("workyear_marktype_id");

                entity.HasOne(d => d.WorkyearMarktype)
                    .WithMany(p => p.WorkYearsMarkTypesValues)
                    .HasForeignKey(d => d.WorkyearMarktypeId)
                    .HasConstraintName("FK_WorkYears_MarkTypes_Values_WorkYears_MarkTypes");
            });

            modelBuilder.Entity<ZwastedWorkYearsGroupsExtra>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_WorkYears_Groups_Extra");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("string");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtra)
                    .HasForeignKey(d => d.WorkYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_WorkYears");
            });

            modelBuilder.Entity<ZwastedWorkYearsGroupsExtraItems>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_WorkYears_Groups_Extra_Items");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.ExtraId).HasColumnName("extra_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.Extra)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtraItems)
                    .HasForeignKey(d => d.ExtraId)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_Items_WorkYears_Groups_Extra");
            });

            modelBuilder.Entity<ZwastedWorkYearsGroupsExtraSets>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_WorkYears_Groups_Extra_Sets");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.HasOne(d => d.WorkYearNavigation)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtraSets)
                    .HasForeignKey(d => d.WorkYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_Sets_WorkYears");
            });

            modelBuilder.Entity<ZwastedWorkYearsGroupsExtraSetsSources>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_WorkYears_Groups_Extra_Sets_Sources");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasicgroupId).HasColumnName("basicgroup_id");

                entity.Property(e => e.SetId).HasColumnName("set_id");

                entity.HasOne(d => d.Basicgroup)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtraSetsSources)
                    .HasForeignKey(d => d.BasicgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_Sets_Sources_WorkYears_Groups_Basic");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtraSetsSources)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_Sets_Sources_WorkYears_Groups_Extra_Sets");
            });

            modelBuilder.Entity<ZwastedWorkYearsGroupsExtraSources>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_WorkYears_Groups_Extra_Sources");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.BasicId).HasColumnName("basic_id");

                entity.Property(e => e.ExtraId).HasColumnName("extra_id");

                entity.HasOne(d => d.Extra)
                    .WithMany(p => p.ZwastedWorkYearsGroupsExtraSources)
                    .HasForeignKey(d => d.ExtraId)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_Sources_WorkYears_Groups_Extra");
            });

            modelBuilder.Entity<ZwastedZWorkYearsGroupsExtra>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("zwasted_zWorkYears_Groups_Extra");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Descr).HasColumnType("string");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("shortstring");

                entity.Property(e => e.SetId).HasColumnName("set_id");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.ZwastedZWorkYearsGroupsExtra)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_WorkYears_Groups_Extra_WorkYears_Groups_Extra_Sets");
            });
        }
    }
}
