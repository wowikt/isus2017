using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using IsusCoreFullNet2017Spa.EntityFrameworkCore;
using Abp.Authorization;
using Abp.BackgroundJobs;
using Abp.Notifications;

namespace IsusCoreFullNet2017Spa.Migrations
{
    [DbContext(typeof(IsusCoreFullNet2017SpaDbContext))]
    partial class IsusCoreFullNet2017SpaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abp.Application.Editions.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AbpEditions");
                });

            modelBuilder.Entity("Abp.Application.Features.FeatureSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FeatureSetting");
                });

            modelBuilder.Entity("Abp.Auditing.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(256);

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasMaxLength(128);

                    b.Property<string>("CustomData")
                        .HasMaxLength(2000);

                    b.Property<string>("Exception")
                        .HasMaxLength(2000);

                    b.Property<int>("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime");

                    b.Property<int?>("ImpersonatorTenantId");

                    b.Property<long?>("ImpersonatorUserId");

                    b.Property<string>("MethodName")
                        .HasMaxLength(256);

                    b.Property<string>("Parameters")
                        .HasMaxLength(1024);

                    b.Property<string>("ServiceName")
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionDuration");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpAuditLogs");
                });

            modelBuilder.Entity("Abp.Authorization.PermissionSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsGranted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId", "ClaimType");

                    b.ToTable("AbpRoleClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("EmailAddress");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.Property<long?>("UserLinkId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress");

                    b.HasIndex("UserName");

                    b.HasIndex("TenantId", "EmailAddress");

                    b.HasIndex("TenantId", "UserId");

                    b.HasIndex("TenantId", "UserName");

                    b.ToTable("AbpUserAccounts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "ClaimType");

                    b.ToTable("AbpUserClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "UserId");

                    b.HasIndex("TenantId", "LoginProvider", "ProviderKey");

                    b.ToTable("AbpUserLogins");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLoginAttempt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(256);

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreationTime");

                    b.Property<byte>("Result");

                    b.Property<string>("TenancyName")
                        .HasMaxLength(64);

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.Property<string>("UserNameOrEmailAddress")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("UserId", "TenantId");

                    b.HasIndex("TenancyName", "UserNameOrEmailAddress", "Result");

                    b.ToTable("AbpUserLoginAttempts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserOrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("OrganizationUnitId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "OrganizationUnitId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserOrganizationUnits");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "RoleId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserRoles");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserTokens");
                });

            modelBuilder.Entity("Abp.BackgroundJobs.BackgroundJobInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsAbandoned");

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasMaxLength(1048576);

                    b.Property<string>("JobType")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<DateTime?>("LastTryTime");

                    b.Property<DateTime>("NextTryTime");

                    b.Property<byte>("Priority");

                    b.Property<short>("TryCount");

                    b.HasKey("Id");

                    b.HasIndex("IsAbandoned", "NextTryTime");

                    b.ToTable("AbpBackgroundJobs");
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.Property<string>("Value")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpSettings");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Icon")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDisabled");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpLanguages");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguageText", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(67108864);

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Source", "LanguageName", "Key");

                    b.ToTable("AbpLanguageTexts");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Data")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("ExcludedUserIds")
                        .HasMaxLength(131072);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(96);

                    b.Property<byte>("Severity");

                    b.Property<string>("TenantIds")
                        .HasMaxLength(131072);

                    b.Property<string>("UserIds")
                        .HasMaxLength(131072);

                    b.HasKey("Id");

                    b.ToTable("AbpNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationSubscriptionInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .HasMaxLength(96);

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NotificationName", "EntityTypeName", "EntityId", "UserId");

                    b.HasIndex("TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId");

                    b.ToTable("AbpNotificationSubscriptions");
                });

            modelBuilder.Entity("Abp.Notifications.TenantNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Data")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(96);

                    b.Property<byte>("Severity");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("AbpTenantNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.UserNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("State");

                    b.Property<int?>("TenantId");

                    b.Property<Guid>("TenantNotificationId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "State", "CreationTime");

                    b.ToTable("AbpUserNotifications");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(95);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<long?>("ParentId");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("TenantId", "Code");

                    b.ToTable("AbpOrganizationUnits");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.Authorization.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Description")
                        .HasMaxLength(5000);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsStatic");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenantId", "NormalizedName");

                    b.ToTable("AbpRoles");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.Authorization.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AuthenticationSource")
                        .HasMaxLength(64);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("EmailConfirmationCode")
                        .HasMaxLength(328);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEmailConfirmed");

                    b.Property<bool>("IsLockoutEnabled");

                    b.Property<bool>("IsPhoneNumberConfirmed");

                    b.Property<bool>("IsTwoFactorEnabled");

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<DateTime?>("LockoutEndDateUtc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedEmailAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("PasswordResetCode")
                        .HasMaxLength(328);

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenantId", "NormalizedEmailAddress");

                    b.HasIndex("TenantId", "NormalizedUserName");

                    b.ToTable("AbpUsers");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int?>("AuthorId")
                        .HasColumnName("author_id");

                    b.Property<int>("CounterAuthorRejects")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("counter_AuthorRejects")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("CounterExpertRejects")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("counter_ExpertRejects")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("CounterIterations")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("counter_Iterations")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("CreatorId")
                        .HasColumnName("creator_id");

                    b.Property<string>("Data")
                        .HasColumnType("xml");

                    b.Property<string>("DocContent");

                    b.Property<DateTime>("DocDate");

                    b.Property<string>("DocNum")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("DocNumInt")
                        .HasColumnName("DocNum_Int");

                    b.Property<int?>("ExpertId")
                        .HasColumnName("expert_id");

                    b.Property<DateTime?>("FirstProjectDate");

                    b.Property<bool?>("IsAutoNum")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsEmpty")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("LockerSession")
                        .HasColumnName("locker_session")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ObjectStateId")
                        .HasColumnName("objectstate_id");

                    b.Property<int>("ObjectTypeId")
                        .HasColumnName("objectype_id");

                    b.Property<int?>("OrgId")
                        .HasColumnName("org_id");

                    b.Property<int?>("WorkYear");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ExpertId");

                    b.HasIndex("LockerSession");

                    b.HasIndex("ObjectStateId");

                    b.HasIndex("ObjectTypeId");

                    b.HasIndex("OrgId");

                    b.HasIndex("WorkYear");

                    b.ToTable("A_Objects");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectEz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("EzContent")
                        .IsRequired()
                        .HasColumnName("ez_content")
                        .HasMaxLength(500);

                    b.Property<string>("EzData")
                        .IsRequired()
                        .HasColumnName("ez_data")
                        .HasColumnType("xml");

                    b.Property<DateTime>("EzDate")
                        .HasColumnName("ez_date");

                    b.Property<string>("EzSigma")
                        .HasColumnName("ez_sigma")
                        .HasMaxLength(500);

                    b.Property<int>("ObjectId")
                        .HasColumnName("object_id");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.ToTable("A_Objects_EZ");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<bool?>("AutoAffirm")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<int>("Compatibility")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("CreatorSolo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DirectInput")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("DivisionId")
                        .HasColumnName("division_id");

                    b.Property<bool?>("IsObsolete")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsOrged")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("IsUniqueNum")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("IsYeared")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("JournalId")
                        .HasColumnName("journal_id");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(500);

                    b.Property<int>("PermissionMask")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((11))");

                    b.Property<string>("ProcContentor")
                        .HasMaxLength(500);

                    b.Property<string>("ProcDataLoader")
                        .HasMaxLength(500);

                    b.Property<string>("ProcPoster")
                        .HasMaxLength(500);

                    b.Property<string>("ProcSaveTrigger")
                        .HasMaxLength(500);

                    b.Property<string>("ProcValidator")
                        .HasMaxLength(500);

                    b.Property<bool?>("ShowInList")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("JournalId");

                    b.HasIndex("Label")
                        .IsUnique()
                        .HasName("uc_Label");

                    b.ToTable("A_ObjectTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectTypeJournal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Postfix")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("postfix")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("prefix")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<short>("ResetMonth")
                        .HasColumnName("reset_month");

                    b.HasKey("Id");

                    b.ToTable("A_ObjectTypes_Journals");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectTypePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("ObjectTypeId")
                        .HasColumnName("objectype_id");

                    b.Property<int>("Permissions")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("ObjectTypeId", "UserId")
                        .IsUnique()
                        .HasName("IX_A_ObjectTypes_Permissions");

                    b.ToTable("A_ObjectTypes_Permissions");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectValidation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<bool?>("IsValid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("ObjectId")
                        .HasColumnName("object_id");

                    b.Property<int>("ObjectStateId")
                        .HasColumnName("objectstate_id");

                    b.Property<string>("Session")
                        .IsRequired()
                        .HasColumnName("session")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ObjectStateId");

                    b.HasIndex("Session");

                    b.ToTable("A_Objects_Validation");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectValidationResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("category")
                        .HasDefaultValueSql("('E')")
                        .HasMaxLength(1);

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnName("descr")
                        .HasMaxLength(500);

                    b.Property<int>("ValidationId")
                        .HasColumnName("validation_id");

                    b.HasKey("Id");

                    b.HasIndex("ValidationId");

                    b.ToTable("A_Objects_Validation_Results");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.ATask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int?>("AuthorId")
                        .HasColumnName("author_id");

                    b.Property<string>("Data")
                        .HasColumnType("xml");

                    b.Property<DateTime>("Deadline")
                        .HasColumnName("deadline");

                    b.Property<DateTime>("Dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("Endtime")
                        .HasColumnName("endtime");

                    b.Property<int?>("FactId")
                        .HasColumnName("fact_id");

                    b.Property<DateTime>("Failtime")
                        .HasColumnName("failtime");

                    b.Property<int?>("HookedObjectId")
                        .HasColumnName("hooked_object_id");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("PausedObjectId")
                        .HasColumnName("paused_object_id");

                    b.Property<int>("ReceiverId")
                        .HasColumnName("receiver_id");

                    b.Property<DateTime>("Showtime")
                        .HasColumnName("showtime");

                    b.Property<int?>("Tag");

                    b.Property<string>("Txt")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("FactId");

                    b.HasIndex("HookedObjectId");

                    b.HasIndex("PausedObjectId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("A_Tasks");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("ValueBinary")
                        .HasColumnName("value_binary");

                    b.Property<bool?>("ValueBit")
                        .HasColumnName("value_bit");

                    b.Property<DateTime?>("ValueDatetime")
                        .HasColumnName("value_datetime");

                    b.Property<int?>("ValueInt")
                        .HasColumnName("value_int");

                    b.Property<string>("ValueStr")
                        .HasColumnName("value_str")
                        .HasMaxLength(500);

                    b.Property<string>("ValueXml")
                        .HasColumnName("value_xml")
                        .HasColumnType("xml");

                    b.HasKey("Id");

                    b.ToTable("A_Variables");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CActivityType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_ActivityTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CDivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_Divisions");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CEducationType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_EducationTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CMarkType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_MarkTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CObjectState", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_ObjectStates");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CPeriodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PeriodCount");

                    b.Property<string>("PeriodGroup")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PeriodIndex");

                    b.HasKey("Id");

                    b.ToTable("C_PeriodTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CWorkCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_WorkCategories");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.CWorkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("C_WorkTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.Fact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<DateTime>("Dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("ObjectId")
                        .HasColumnName("object_id");

                    b.Property<int?>("ObjectIdOut")
                        .HasColumnName("object_id_out");

                    b.Property<int?>("Tag");

                    b.Property<int?>("WorkYear");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.HasIndex("ObjectIdOut");

                    b.HasIndex("WorkYear");

                    b.ToTable("F");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationCud", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<string>("CudText")
                        .HasColumnName("cud_text");

                    b.Property<int>("ProgOptId")
                        .HasColumnName("prog_opt_id");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ProgOptId");

                    b.HasIndex("PupilId");

                    b.HasIndex("Id", "ActivityId", "ProgOptId", "CudText", "PupilId")
                        .HasName("IX_FEducationCUD_PupilId");

                    b.ToTable("F_Education_CUD");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationCudMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("FactId")
                        .HasColumnName("fact_id");

                    b.Property<int>("MarkValue")
                        .HasColumnName("mark_value");

                    b.Property<int>("MarktypeId")
                        .HasColumnName("marktype_id");

                    b.HasKey("Id");

                    b.HasIndex("FactId");

                    b.HasIndex("MarktypeId", "MarkValue", "FactId")
                        .HasName("IX_FEducationCUDMarks_FactId");

                    b.ToTable("F_Education_CUD_Marks");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationResult", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("Hours")
                        .HasColumnName("hours");

                    b.Property<int>("MarkMain")
                        .HasColumnName("mark_main");

                    b.Property<int>("PeriodId")
                        .HasColumnName("period_id");

                    b.Property<int?>("PlanId")
                        .HasColumnName("plan_id");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("PlanId");

                    b.HasIndex("PupilId", "ActivityId", "PeriodId")
                        .IsUnique()
                        .HasName("IX_F_Education_Results");

                    b.ToTable("F_Education_Results");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationResultFinal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("Hours")
                        .HasColumnName("hours");

                    b.Property<int?>("MarkExam")
                        .HasColumnName("mark_exam");

                    b.Property<int?>("MarkGod")
                        .HasColumnName("mark_god");

                    b.Property<int?>("MarkItog")
                        .HasColumnName("mark_itog");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("PupilId");

                    b.ToTable("F_Education_Results_Final");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingMainMark", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<bool>("IsAbsent");

                    b.Property<int>("LessonLength")
                        .HasColumnName("lesson_length");

                    b.Property<string>("MarkType")
                        .IsRequired()
                        .HasColumnName("mark_type")
                        .HasMaxLength(50);

                    b.Property<int?>("MarkValue")
                        .HasColumnName("mark_value");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.Property<int>("TimeLate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("time_late")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("PupilId", "IsAbsent", "DtStart")
                        .HasName("IX_Education_Studying_MainMarks_PupilId_IsAbsent_DtStart");

                    b.ToTable("F_Education_Studying_MainMarks");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingSpecialMark", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("EduDate")
                        .HasColumnName("edu_date");

                    b.Property<int>("LessonVolume")
                        .HasColumnName("lesson_volume");

                    b.Property<int>("MarkValue")
                        .HasColumnName("mark_value");

                    b.Property<int>("MarktypeId")
                        .HasColumnName("marktype_id");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("MarktypeId");

                    b.HasIndex("PupilId");

                    b.HasIndex("LessonVolume", "ActivityId", "MarktypeId", "MarkValue", "PupilId", "EduDate")
                        .HasName("IX_FEducationStudyingSpecialMarks_PupilId_EduDate");

                    b.ToTable("F_Education_Studying_SpecialMarks");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationTeaching", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int?>("BasicgroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("Essay")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("essay")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("ExtragroupId")
                        .HasColumnName("extragroup_id");

                    b.Property<string>("Homework")
                        .IsRequired()
                        .HasColumnName("homework")
                        .HasMaxLength(500);

                    b.Property<int>("LessonLength")
                        .HasColumnName("lesson_length");

                    b.Property<int>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnName("topic")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ExtragroupId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("DtStart", "ActivityId")
                        .HasName("IX_F_Education_Teaching_ActivityId_DtStart");

                    b.ToTable("F_Education_Teaching");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FExpertStudyProgram", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("ExpertId")
                        .HasColumnName("expert_id");

                    b.Property<int>("Grade")
                        .HasColumnName("grade");

                    b.Property<bool?>("IsActual")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ExpertId");

                    b.ToTable("F_Experts_StudyProgram");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupBasicSostav", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("PupilId");

                    b.ToTable("F_Groups_Basic_Sostav");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtra", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("F_Groups_Extra");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("FactId")
                        .HasColumnName("fact_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("FactId");

                    b.ToTable("F_Groups_Extra_Items");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraSostav", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("ItemId")
                        .HasColumnName("item_id");

                    b.Property<int>("PupilId")
                        .HasColumnName("pupil_id");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("PupilId");

                    b.ToTable("F_Groups_Extra_Sostav");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<int>("FactId")
                        .HasColumnName("fact_id");

                    b.HasKey("Id");

                    b.HasIndex("FactId");

                    b.ToTable("F_Groups_Extra_Sources");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyJob", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int?>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int?>("ExtraGroupId")
                        .HasColumnName("extragroup_id");

                    b.Property<double>("Hours")
                        .HasColumnName("hours");

                    b.Property<int>("MetodistId")
                        .HasColumnName("metodist_id");

                    b.Property<int>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ExtraGroupId");

                    b.HasIndex("MetodistId");

                    b.HasIndex("TeacherId");

                    b.ToTable("F_StudyJobs");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("LessonLength");

                    b.Property<int?>("PeriodId")
                        .HasColumnName("period_id");

                    b.Property<DateTime>("PlanEnd")
                        .HasColumnName("plan_end");

                    b.Property<DateTime>("PlanStart")
                        .HasColumnName("plan_start");

                    b.Property<bool>("ShortWeek");

                    b.Property<int>("WeekCount");

                    b.HasKey("Id");

                    b.HasIndex("PeriodId");

                    b.ToTable("F_StudyPlans");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("Grade")
                        .HasColumnName("grade");

                    b.Property<double>("Hours")
                        .HasColumnName("hours");

                    b.Property<int>("PlanId")
                        .HasColumnName("plan_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("PlanId");

                    b.ToTable("F_StudyPlans_Content");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanNagruzka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("Grade")
                        .HasColumnName("grade");

                    b.Property<double>("Hours")
                        .HasColumnName("hours");

                    b.Property<int>("PlanId")
                        .HasColumnName("plan_id");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("F_StudyPlans_Nagruzka");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanRecepient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<int>("PlanId")
                        .HasColumnName("plan_id");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("F_StudyPlans_Recepients");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgram", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("EssayCount")
                        .HasColumnName("essay_count");

                    b.Property<double>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("F_StudyPrograms");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgramContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("FactId")
                        .HasColumnName("fact_id");

                    b.Property<int>("OptId")
                        .HasColumnName("opt_id");

                    b.HasKey("Id");

                    b.HasIndex("FactId");

                    b.HasIndex("OptId");

                    b.ToTable("F_StudyPrograms_Content");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgramRecepient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int?>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<int?>("ExtraGroupId")
                        .HasColumnName("extragroup_id");

                    b.Property<int>("FactId")
                        .HasColumnName("fact_id");

                    b.HasKey("Id");

                    b.HasIndex("ExtraGroupId");

                    b.HasIndex("FactId");

                    b.ToTable("F_StudyPrograms_Recepients");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudySchedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int?>("BasicGroupId")
                        .HasColumnName("basicgroup_id");

                    b.Property<int>("ClassroomId")
                        .HasColumnName("classroom_id");

                    b.Property<DateTime>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int?>("ExtraGroupId")
                        .HasColumnName("extragroup_id");

                    b.Property<bool?>("IsCancelled")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool>("IsExclusive");

                    b.Property<int?>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("ExtraGroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("F_StudySchedule");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FWorker", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int?>("EducationId")
                        .HasColumnName("education_id");

                    b.Property<bool?>("IsTeacher")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("PositionId")
                        .HasColumnName("position_id");

                    b.Property<double?>("StavkaNorma")
                        .HasColumnName("stavka_norma");

                    b.Property<double?>("StavkaValue")
                        .HasColumnName("stavka_value");

                    b.Property<int>("WorkTypeId")
                        .HasColumnName("worktype_id");

                    b.Property<int>("WorkerId")
                        .HasColumnName("worker_id");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("PositionId");

                    b.HasIndex("WorkTypeId");

                    b.HasIndex("WorkerId");

                    b.ToTable("F_Workers");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FWorkerTeaching", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<DateTime?>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TeacherId");

                    b.ToTable("F_Workers_Teaching");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.IsusUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("AccountName")
                        .HasColumnName("account_name")
                        .HasMaxLength(50);

                    b.Property<string>("AccountPwd")
                        .HasColumnName("account_pwd")
                        .HasMaxLength(50);

                    b.Property<byte[]>("AccountPwdMd5")
                        .HasColumnName("account_pwd_md5")
                        .HasMaxLength(100);

                    b.Property<bool?>("AccountValid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("account_valid")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("ContactInfo")
                        .HasMaxLength(500);

                    b.Property<string>("CurrentName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("CurrentShortName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Data")
                        .HasColumnType("xml");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsBoss")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsDeveloper")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<byte[]>("Photo");

                    b.Property<bool?>("SurplusIsTeacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("surplus_IsTeacher")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SurplusKlassId")
                        .HasColumnName("surplus_klass_id");

                    b.Property<int?>("Tmp")
                        .HasColumnName("tmp");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr");

                    b.Property<bool?>("HasMainMarks")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("HasSpecialMarks")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsAbstract")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("Parent")
                        .HasColumnName("parent");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("TypeId")
                        .HasColumnName("type_id");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("S_Activities");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SClassroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsShareable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("string");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("shortstring");

                    b.HasKey("Id");

                    b.ToTable("S_Classrooms");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SiteDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsVisible");

                    b.Property<string>("PageContent");

                    b.Property<int>("PageIndex");

                    b.HasKey("Id");

                    b.ToTable("SiteDocuments");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SOpt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<int>("AuthorId")
                        .HasColumnName("author_id");

                    b.Property<int?>("DocId")
                        .HasColumnName("doc_id");

                    b.Property<string>("Grades")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("grades")
                        .HasColumnType("shortstring")
                        .HasDefaultValueSql("('')");

                    b.Property<int>("Hours")
                        .HasColumnName("hours");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsFrozen")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsShareable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("LeadingFormUd")
                        .HasColumnName("LeadingFormUD")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("OrgForm")
                        .HasMaxLength(500);

                    b.Property<string>("Result");

                    b.Property<string>("SimpleKim")
                        .HasColumnName("SimpleKIM");

                    b.Property<string>("SimpleResources");

                    b.Property<string>("TargetDeveloping")
                        .HasColumnName("Target_Developing");

                    b.Property<string>("TargetStudy")
                        .HasColumnName("Target_Study");

                    b.Property<string>("TargetTeaching")
                        .HasColumnName("Target_Teaching");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DocId");

                    b.ToTable("S_OPT");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Data")
                        .HasColumnType("xml");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("SpravName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("S_Organizations");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr");

                    b.Property<string>("FullName")
                        .HasMaxLength(500);

                    b.Property<int?>("GroupIndex")
                        .HasColumnName("group_index");

                    b.Property<bool?>("IsAbstract")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("IsGos")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Parent")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("parent")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("StavkaHours");

                    b.HasKey("Id");

                    b.ToTable("S_Positions");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.UserOrganizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasColumnName("descr")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("Users_Organizer");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.UserParentship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<int>("ChildId")
                        .HasColumnName("child_id");

                    b.Property<int>("ParentId")
                        .HasColumnName("parent_id");

                    b.Property<string>("RoleDescr")
                        .HasColumnName("role_descr")
                        .HasMaxLength(500);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("role_name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("ParentId");

                    b.ToTable("Users_Parentship");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.UserSession", b =>
                {
                    b.Property<string>("Session")
                        .HasColumnName("session")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ActiveWorkYear");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnName("login_time");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Session");

                    b.HasIndex("Session")
                        .IsUnique()
                        .HasName("IX_Users_Sessions");

                    b.HasIndex("UserId");

                    b.ToTable("Users_Sessions");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearGroupBasic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<string>("Descr")
                        .HasMaxLength(500);

                    b.Property<int>("Grade")
                        .HasColumnName("grade");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("WorkYear");

                    b.HasKey("Id");

                    b.HasIndex("WorkYear");

                    b.ToTable("WorkYears_Groups_Basic");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearItem", b =>
                {
                    b.Property<int>("WorkYear");

                    b.Property<DateTime>("DtEnd")
                        .HasColumnName("dt_end");

                    b.Property<DateTime>("DtStart")
                        .HasColumnName("dt_start");

                    b.Property<int>("GradeMax")
                        .HasColumnName("grade_max");

                    b.Property<int>("GradeMin")
                        .HasColumnName("grade_min");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("WorkYear");

                    b.ToTable("WorkYears");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearMarkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<bool?>("IsIntegral")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("MarkTypeId")
                        .HasColumnName("marktype_id");

                    b.Property<int>("WorkYear");

                    b.HasKey("Id");

                    b.HasIndex("MarkTypeId");

                    b.HasIndex("WorkYear");

                    b.ToTable("WorkYears_MarkTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearMarkTypeValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uid");

                    b.Property<bool?>("IsDefault")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("ValueInt")
                        .HasColumnName("value_int");

                    b.Property<string>("ValueStr")
                        .IsRequired()
                        .HasColumnName("value_str")
                        .HasMaxLength(50);

                    b.Property<int>("WorkYearMarkTypeId")
                        .HasColumnName("workyear_marktype_id");

                    b.HasKey("Id");

                    b.HasIndex("WorkYearMarkTypeId", "ValueInt")
                        .IsUnique()
                        .HasName("IX_WorkYears_MarkTypes_Values");

                    b.ToTable("WorkYears_MarkTypes_Values");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.MultiTenancy.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConnectionString")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<int?>("EditionId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("TenancyName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("EditionId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenancyName");

                    b.ToTable("AbpTenants");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");

                    b.Property<int>("EditionId");

                    b.HasIndex("EditionId", "Name");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("EditionFeatureSetting");
                });

            modelBuilder.Entity("Abp.MultiTenancy.TenantFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");

                    b.Property<int>("TenantId");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("TenantFeatureSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<int>("RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("RolePermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<long>("UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("UserPermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Roles.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Settings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.HasOne("Abp.Organizations.OrganizationUnit", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.Authorization.Roles.Role", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.Authorization.Users.User", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObject", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Author")
                        .WithMany("AObjectsAuthor")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_A_Objects_Users2");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Creator")
                        .WithMany("AObjectsCreator")
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("FK_A_Objects_Users");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Expert")
                        .WithMany("AObjectsExpert")
                        .HasForeignKey("ExpertId")
                        .HasConstraintName("FK_A_Objects_Users1");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.UserSession", "LockerSessionNavigation")
                        .WithMany("AObjects")
                        .HasForeignKey("LockerSession")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CObjectState", "ObjectState")
                        .WithMany("AObjects")
                        .HasForeignKey("ObjectStateId")
                        .HasConstraintName("FK_A_Objects_C_ObjectStates");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObjectType", "ObjectType")
                        .WithMany("AObjects")
                        .HasForeignKey("ObjectTypeId")
                        .HasConstraintName("FK_A_Objects_A_ObjectTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SOrganization", "Org")
                        .WithMany("AObjects")
                        .HasForeignKey("OrgId")
                        .HasConstraintName("FK_A_Objects_S_Organizations");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.WorkYearItem", "WorkYearItemObject")
                        .WithMany("AObjects")
                        .HasForeignKey("WorkYear");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectEz", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "Object")
                        .WithMany("AObjectsEz")
                        .HasForeignKey("ObjectId")
                        .HasConstraintName("FK_A_Objects_EZ_A_Objects")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectType", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CDivision", "Division")
                        .WithMany("AObjectTypes")
                        .HasForeignKey("DivisionId")
                        .HasConstraintName("FK_A_ObjectTypes_C_Divisions");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObjectTypeJournal", "Journal")
                        .WithMany("AObjectTypes")
                        .HasForeignKey("JournalId")
                        .HasConstraintName("FK_A_ObjectTypes_A_ObjectTypes_Journals");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectTypePermission", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObjectType", "ObjectType")
                        .WithMany("AObjectTypesPermissions")
                        .HasForeignKey("ObjectTypeId")
                        .HasConstraintName("FK_A_ObjectTypes_Permissions_A_ObjectTypes")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "IsusUser")
                        .WithMany("AObjectTypesPermissions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_A_ObjectTypes_Permissions_Users")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectValidation", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CObjectState", "ObjectState")
                        .WithMany("AObjectsValidation")
                        .HasForeignKey("ObjectStateId")
                        .HasConstraintName("FK_A_Objects_Validation_C_ObjectStates");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.UserSession", "SessionNavigation")
                        .WithMany("AObjectsValidation")
                        .HasForeignKey("Session")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.AObjectValidationResult", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObjectValidation", "Validation")
                        .WithMany("AObjectsValidationResults")
                        .HasForeignKey("ValidationId")
                        .HasConstraintName("FK_A_Objects_Validation_Results_A_Objects_Validation")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.ATask", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Author")
                        .WithMany("ATasksAuthor")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_A_Tasks_Users");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "Fact")
                        .WithMany("ATasks")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_A_Tasks_F");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "HookedObject")
                        .WithMany("ATasksHookedObject")
                        .HasForeignKey("HookedObjectId")
                        .HasConstraintName("FK_A_Tasks_A_Objects");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "PausedObject")
                        .WithMany("ATasksPausedObject")
                        .HasForeignKey("PausedObjectId")
                        .HasConstraintName("FK_A_Tasks_A_Objects1");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Receiver")
                        .WithMany("ATasksReceiver")
                        .HasForeignKey("ReceiverId")
                        .HasConstraintName("FK_A_Tasks_Users1");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.Fact", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "Object")
                        .WithMany("FObject")
                        .HasForeignKey("ObjectId")
                        .HasConstraintName("FK_F_A_Objects");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "ObjectIdOutNavigation")
                        .WithMany("FObjectIdOutNavigation")
                        .HasForeignKey("ObjectIdOut")
                        .HasConstraintName("FK_F_A_Objects1");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.WorkYearItem", "WorkYearItemNavigation")
                        .WithMany("F")
                        .HasForeignKey("WorkYear");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationCud", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationCud")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_CUD_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationCud")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationCud", "Id")
                        .HasConstraintName("FK_F_Education_CUD_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyProgramContent", "ProgOpt")
                        .WithMany("FEducationCud")
                        .HasForeignKey("ProgOptId")
                        .HasConstraintName("FK_F_Education_CUD_F_StudyPrograms_Content");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FEducationCud")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Education_CUD_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationCudMark", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FEducationCud", "Fact")
                        .WithMany("FEducationCudMarks")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_F_Education_CUD_Marks_F_Education_CUD")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CMarkType", "Marktype")
                        .WithMany("FEducationCudMarks")
                        .HasForeignKey("MarktypeId")
                        .HasConstraintName("FK_F_Education_CUD_Marks_C_MarkTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationResult", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationResults")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_Results_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationResult")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationResult", "Id")
                        .HasConstraintName("FK_F_Education_Results_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CPeriodType", "Period")
                        .WithMany("FEducationResults")
                        .HasForeignKey("PeriodId")
                        .HasConstraintName("FK_F_Education_Results_C_PeriodTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", "Plan")
                        .WithMany("FEducationResults")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_F_Education_Results_F_StudyPlans");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FEducationResults")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Education_Results_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationResultFinal", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationResultsFinal")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_Results_Final_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationResultFinal")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationResultFinal", "Id")
                        .HasConstraintName("FK_F_Education_Results_Final_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FEducationResultsFinal")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Education_Results_Final_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingMainMark", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationStudyingMainMarks")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_Studying_MainMarks_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationStudyingMainMark")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingMainMark", "Id")
                        .HasConstraintName("FK_F_Education_Studying_MainMarks_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FEducationStudyingMainMarks")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Education_Studying_MainMarks_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingSpecialMark", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationStudyingSpecialMarks")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_Studying_SpecialMarks_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationStudyingSpecialMark")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationStudyingSpecialMark", "Id")
                        .HasConstraintName("FK_F_Education_Studying_SpecialMarks_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CMarkType", "Marktype")
                        .WithMany("FEducationStudyingSpecialMarks")
                        .HasForeignKey("MarktypeId")
                        .HasConstraintName("FK_F_Education_Studying_SpecialMarks_C_MarkTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FEducationStudyingSpecialMarks")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Education_Studying_SpecialMarks_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FEducationTeaching", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FEducationTeaching")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Education_Teaching_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", "Extragroup")
                        .WithMany("FEducationTeaching")
                        .HasForeignKey("ExtragroupId")
                        .HasConstraintName("FK_F_Education_Teaching_F_Groups_Extra_Items");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FEducationTeaching")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FEducationTeaching", "Id")
                        .HasConstraintName("FK_F_Education_Teaching_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Teacher")
                        .WithMany("FEducationTeaching")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_F_Education_Teaching_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FExpertStudyProgram", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FExpertsStudyProgram")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Experts_StudyProgram_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Expert")
                        .WithMany("FExpertsStudyProgram")
                        .HasForeignKey("ExpertId")
                        .HasConstraintName("FK_F_Experts_StudyProgram_Users");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FExpertStudyProgram")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FExpertStudyProgram", "Id")
                        .HasConstraintName("FK_F_Experts_StudyProgram_F")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupBasicSostav", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FGroupBasicSostav")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FGroupBasicSostav", "Id")
                        .HasConstraintName("FK_F_Groups_Basic_Sostav_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FGroupsBasicSostav")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Groups_Basic_Sostav_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtra", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FGroupExtra")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FGroupExtra", "Id")
                        .HasConstraintName("FK_F_Groups_Extra_F")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtra", "Fact")
                        .WithMany("FGroupsExtraItems")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_F_Groups_Extra_Items_F_Groups_Extra")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraSostav", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", "Item")
                        .WithMany("FGroupsExtraSostav")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_F_Groups_Extra_Sostav_F_Groups_Extra_Items")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Pupil")
                        .WithMany("FGroupsExtraSostav")
                        .HasForeignKey("PupilId")
                        .HasConstraintName("FK_F_Groups_Extra_Sostav_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraSource", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtra", "Fact")
                        .WithMany("FGroupsExtraSources")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_F_Groups_Extra_Sources_F_Groups_Extra")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyJob", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FStudyJobs")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_StudyJobs_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", "Extragroup")
                        .WithMany("FStudyJobs")
                        .HasForeignKey("ExtraGroupId")
                        .HasConstraintName("FK_F_StudyJobs_F_Groups_Extra_Items");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FStudyJob")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FStudyJob", "Id")
                        .HasConstraintName("FK_F_StudyJobs_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Metodist")
                        .WithMany("FStudyJobsMetodist")
                        .HasForeignKey("MetodistId")
                        .HasConstraintName("FK_F_StudyJobs_Users1");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Teacher")
                        .WithMany("FStudyJobsTeacher")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_F_StudyJobs_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FStudyPlan")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", "Id")
                        .HasConstraintName("FK_F_StudyPlans_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CPeriodType", "Period")
                        .WithMany("FStudyPlans")
                        .HasForeignKey("PeriodId")
                        .HasConstraintName("FK_F_StudyPlans_C_PeriodTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanContent", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FStudyPlansContent")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_StudyPlans_Content_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", "Plan")
                        .WithMany("FStudyPlansContent")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_F_StudyPlans_Content_F_StudyPlans")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanNagruzka", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", "Plan")
                        .WithMany("FStudyPlansNagruzka")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_F_StudyPlans_Nagruzka_F_StudyPlans")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyPlanRecepient", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyPlan", "Plan")
                        .WithMany("FStudyPlansRecepients")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_F_StudyPlans_Recepients_F_StudyPlans")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgram", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FStudyPrograms")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_StudyPrograms_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FStudyProgram")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FStudyProgram", "Id")
                        .HasConstraintName("FK_F_StudyPrograms_F")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgramContent", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyProgram", "Fact")
                        .WithMany("FStudyProgramsContent")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_F_StudyPrograms_Content_F_StudyPrograms")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SOpt", "Opt")
                        .WithMany("FStudyProgramsContent")
                        .HasForeignKey("OptId")
                        .HasConstraintName("FK_F_StudyPrograms_Content_S_OPT");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudyProgramRecepient", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", "ExtraGroup")
                        .WithMany("FStudyProgramsRecepients")
                        .HasForeignKey("ExtraGroupId")
                        .HasConstraintName("FK_F_StudyPrograms_Recepients_F_Groups_Extra_Items");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FStudyProgram", "Fact")
                        .WithMany("FStudyProgramsRecepients")
                        .HasForeignKey("FactId")
                        .HasConstraintName("FK_F_StudyPrograms_Recepients_F_StudyPrograms")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FStudySchedule", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FStudySchedule")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_StudySchedule_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SClassroom", "Classroom")
                        .WithMany("FStudySchedule")
                        .HasForeignKey("ClassroomId")
                        .HasConstraintName("FK_F_StudySchedule_S_Classrooms");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.FGroupExtraItem", "Extragroup")
                        .WithMany("FStudySchedule")
                        .HasForeignKey("ExtraGroupId")
                        .HasConstraintName("FK_F_StudySchedule_F_Groups_Extra_Items");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FStudySchedule")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FStudySchedule", "Id")
                        .HasConstraintName("FK_F_StudySchedule_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Teacher")
                        .WithMany("FStudySchedule")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_F_StudySchedule_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FWorker", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CEducationType", "Education")
                        .WithMany("FWorkers")
                        .HasForeignKey("EducationId")
                        .HasConstraintName("FK_F_Workers_C_EducationTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FWorker")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FWorker", "Id")
                        .HasConstraintName("FK_F_Workers_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SPosition", "Position")
                        .WithMany("FWorkers")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("FK_F_Workers_S_Positions");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CWorkType", "Worktype")
                        .WithMany("FWorkers")
                        .HasForeignKey("WorkTypeId")
                        .HasConstraintName("FK_F_Workers_C_WorkTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Worker")
                        .WithMany("FWorkers")
                        .HasForeignKey("WorkerId")
                        .HasConstraintName("FK_F_Workers_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.FWorkerTeaching", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("FWorkersTeaching")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_F_Workers_Teaching_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CWorkCategory", "Category")
                        .WithMany("FWorkersTeaching")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_F_Workers_Teaching_C_WorkCategories");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.Fact", "U")
                        .WithOne("FWorkerTeaching")
                        .HasForeignKey("IsusCoreFullNet2017Spa.IsusModels.FWorkerTeaching", "Id")
                        .HasConstraintName("FK_F_Workers_Teaching_F")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Teacher")
                        .WithMany("FWorkersTeaching")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_F_Workers_Teaching_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SActivity", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CActivityType", "Type")
                        .WithMany("SActivities")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_S_Activities_C_ActivityTypes");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.SOpt", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.SActivity", "Activity")
                        .WithMany("SOpt")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_S_OPT_S_Activities");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Author")
                        .WithMany("SOpt")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_S_OPT_Users");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.AObject", "Doc")
                        .WithMany("SOpt")
                        .HasForeignKey("DocId")
                        .HasConstraintName("FK_S_OPT_A_Objects")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.UserParentship", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Child")
                        .WithMany("UsersParentshipChild")
                        .HasForeignKey("ChildId")
                        .HasConstraintName("FK_Users_Parentship_Users1");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "Parent")
                        .WithMany("UsersParentshipParent")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK_Users_Parentship_Users");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.UserSession", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.IsusUser", "IsusUser")
                        .WithMany("UsersSessions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_Sessions_Users")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearGroupBasic", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.WorkYearItem", "WorkYearItemNavigation")
                        .WithMany("WorkYearsGroupsBasic")
                        .HasForeignKey("WorkYear")
                        .HasConstraintName("FK_WorkYears_Groups_Basic_WorkYears");
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearMarkType", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.CMarkType", "MarkType")
                        .WithMany("WorkYearsMarkTypes")
                        .HasForeignKey("MarkTypeId")
                        .HasConstraintName("FK_WorkYears_MarkTypes_C_MarkTypes");

                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.WorkYearItem", "WorkYearItemNavigation")
                        .WithMany("WorkYearsMarkTypes")
                        .HasForeignKey("WorkYear")
                        .HasConstraintName("FK_WorkYears_MarkTypes_WorkYears")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.IsusModels.WorkYearMarkTypeValue", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.IsusModels.WorkYearMarkType", "WorkyearMarktype")
                        .WithMany("WorkYearsMarkTypesValues")
                        .HasForeignKey("WorkYearMarkTypeId")
                        .HasConstraintName("FK_WorkYears_MarkTypes_Values_WorkYears_MarkTypes")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IsusCoreFullNet2017Spa.MultiTenancy.Tenant", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId");

                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Roles.Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasOne("IsusCoreFullNet2017Spa.Authorization.Users.User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
