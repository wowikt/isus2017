using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IsusCoreFullNet2017Spa.Migrations
{
    public partial class CreateIsusTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A_ObjectTypes_Journals",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    postfix = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    prefix = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    reset_month = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_ObjectTypes_Journals", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "A_Variables",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    value_binary = table.Column<byte[]>(nullable: true),
                    value_bit = table.Column<bool>(nullable: true),
                    value_datetime = table.Column<DateTime>(nullable: true),
                    value_int = table.Column<int>(nullable: true),
                    value_str = table.Column<string>(maxLength: 500, nullable: true),
                    value_xml = table.Column<string>(type: "xml", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Variables", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_ActivityTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_ActivityTypes", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_Divisions",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_Divisions", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_EducationTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Descr = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_EducationTypes", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_MarkTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_MarkTypes", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_ObjectStates",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_ObjectStates", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_PeriodTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PeriodCount = table.Column<int>(nullable: false),
                    PeriodGroup = table.Column<string>(maxLength: 50, nullable: false),
                    PeriodIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_PeriodTypes", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_WorkCategories",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Descr = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_WorkCategories", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "C_WorkTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descr = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_WorkTypes", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    account_name = table.Column<string>(maxLength: 50, nullable: true),
                    account_pwd = table.Column<string>(maxLength: 50, nullable: true),
                    account_pwd_md5 = table.Column<byte[]>(maxLength: 100, nullable: true),
                    account_valid = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ContactInfo = table.Column<string>(maxLength: 500, nullable: true),
                    CurrentName = table.Column<string>(maxLength: 500, nullable: false),
                    CurrentShortName = table.Column<string>(maxLength: 500, nullable: false),
                    Data = table.Column<string>(type: "xml", nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    IsAdmin = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsBoss = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsDeveloper = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Photo = table.Column<byte[]>(nullable: true),
                    surplus_IsTeacher = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    surplus_klass_id = table.Column<int>(nullable: true),
                    tmp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "S_Classrooms",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descr = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsShareable = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(type: "string", nullable: false),
                    ShortName = table.Column<string>(type: "shortstring", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Classrooms", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "SiteDocuments",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Header = table.Column<string>(maxLength: 500, nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    PageContent = table.Column<string>(nullable: true),
                    PageIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDocuments", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "S_Organizations",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<string>(type: "xml", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SpravName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Organizations", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "S_Positions",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descr = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(maxLength: 500, nullable: true),
                    group_index = table.Column<int>(nullable: true),
                    IsAbstract = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsGos = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    parent = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    StavkaHours = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Positions", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "Users_Organizer",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descr = table.Column<string>(maxLength: 500, nullable: true),
                    dt_end = table.Column<DateTime>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(maxLength: 50, nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Organizer", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "WorkYears",
                columns: table => new
                {
                    WorkYear = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    grade_max = table.Column<int>(nullable: false),
                    grade_min = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkYears", x => x.WorkYear);
                });

            migrationBuilder.CreateTable(
                name: "S_Activities",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descr = table.Column<string>(nullable: true),
                    HasMainMarks = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    HasSpecialMarks = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    IsAbstract = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    parent = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false),
                    type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Activities", x => x.uid);
                    table.ForeignKey(
                        name: "FK_S_Activities_C_ActivityTypes",
                        column: x => x.type_id,
                        principalTable: "C_ActivityTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "A_ObjectTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    AutoAffirm = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Category = table.Column<string>(maxLength: 1, nullable: false),
                    Compatibility = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    CreatorSolo = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DirectInput = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    division_id = table.Column<int>(nullable: true),
                    IsObsolete = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsOrged = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    IsUniqueNum = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    IsYeared = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    journal_id = table.Column<int>(nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    PermissionMask = table.Column<int>(nullable: false, defaultValueSql: "((11))"),
                    ProcContentor = table.Column<string>(maxLength: 500, nullable: true),
                    ProcDataLoader = table.Column<string>(maxLength: 500, nullable: true),
                    ProcPoster = table.Column<string>(maxLength: 500, nullable: true),
                    ProcSaveTrigger = table.Column<string>(maxLength: 500, nullable: true),
                    ProcValidator = table.Column<string>(maxLength: 500, nullable: true),
                    ShowInList = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_ObjectTypes", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_ObjectTypes_C_Divisions",
                        column: x => x.division_id,
                        principalTable: "C_Divisions",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_ObjectTypes_A_ObjectTypes_Journals",
                        column: x => x.journal_id,
                        principalTable: "A_ObjectTypes_Journals",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users_Parentship",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    child_id = table.Column<int>(nullable: false),
                    parent_id = table.Column<int>(nullable: false),
                    role_descr = table.Column<string>(maxLength: 500, nullable: true),
                    role_name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Parentship", x => x.uid);
                    table.ForeignKey(
                        name: "FK_Users_Parentship_Users1",
                        column: x => x.child_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Parentship_Users",
                        column: x => x.parent_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users_Sessions",
                columns: table => new
                {
                    session = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ActiveWorkYear = table.Column<int>(nullable: false),
                    login_time = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Sessions", x => x.session);
                    table.ForeignKey(
                        name: "FK_Users_Sessions_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkYears_Groups_Basic",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descr = table.Column<string>(maxLength: 500, nullable: true),
                    grade = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    WorkYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkYears_Groups_Basic", x => x.uid);
                    table.ForeignKey(
                        name: "FK_WorkYears_Groups_Basic_WorkYears",
                        column: x => x.WorkYear,
                        principalTable: "WorkYears",
                        principalColumn: "WorkYear",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkYears_MarkTypes",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsIntegral = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    marktype_id = table.Column<int>(nullable: false),
                    WorkYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkYears_MarkTypes", x => x.uid);
                    table.ForeignKey(
                        name: "FK_WorkYears_MarkTypes_C_MarkTypes",
                        column: x => x.marktype_id,
                        principalTable: "C_MarkTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkYears_MarkTypes_WorkYears",
                        column: x => x.WorkYear,
                        principalTable: "WorkYears",
                        principalColumn: "WorkYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A_ObjectTypes_Permissions",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    objectype_id = table.Column<int>(nullable: false),
                    Permissions = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_ObjectTypes_Permissions", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_ObjectTypes_Permissions_A_ObjectTypes",
                        column: x => x.objectype_id,
                        principalTable: "A_ObjectTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_A_ObjectTypes_Permissions_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A_Objects",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    author_id = table.Column<int>(nullable: true),
                    counter_AuthorRejects = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    counter_ExpertRejects = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    counter_Iterations = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    creator_id = table.Column<int>(nullable: false),
                    Data = table.Column<string>(type: "xml", nullable: true),
                    DocContent = table.Column<string>(nullable: true),
                    DocDate = table.Column<DateTime>(nullable: false),
                    DocNum = table.Column<string>(maxLength: 50, nullable: false),
                    DocNum_Int = table.Column<int>(nullable: true),
                    expert_id = table.Column<int>(nullable: true),
                    FirstProjectDate = table.Column<DateTime>(nullable: true),
                    IsAutoNum = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsEmpty = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    locker_session = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    objectstate_id = table.Column<int>(nullable: false),
                    objectype_id = table.Column<int>(nullable: false),
                    org_id = table.Column<int>(nullable: true),
                    WorkYear = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Objects", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_Objects_Users2",
                        column: x => x.author_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_Users",
                        column: x => x.creator_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_Users1",
                        column: x => x.expert_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_Users_Sessions_locker_session",
                        column: x => x.locker_session,
                        principalTable: "Users_Sessions",
                        principalColumn: "session",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_A_Objects_C_ObjectStates",
                        column: x => x.objectstate_id,
                        principalTable: "C_ObjectStates",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_A_ObjectTypes",
                        column: x => x.objectype_id,
                        principalTable: "A_ObjectTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_S_Organizations",
                        column: x => x.org_id,
                        principalTable: "S_Organizations",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_WorkYears_WorkYear",
                        column: x => x.WorkYear,
                        principalTable: "WorkYears",
                        principalColumn: "WorkYear",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "A_Objects_Validation",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsValid = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    object_id = table.Column<int>(nullable: false),
                    objectstate_id = table.Column<int>(nullable: false),
                    session = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Objects_Validation", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_Objects_Validation_C_ObjectStates",
                        column: x => x.objectstate_id,
                        principalTable: "C_ObjectStates",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Objects_Validation_Users_Sessions_session",
                        column: x => x.session,
                        principalTable: "Users_Sessions",
                        principalColumn: "session",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkYears_MarkTypes_Values",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDefault = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    value_int = table.Column<int>(nullable: false),
                    value_str = table.Column<string>(maxLength: 50, nullable: false),
                    workyear_marktype_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkYears_MarkTypes_Values", x => x.uid);
                    table.ForeignKey(
                        name: "FK_WorkYears_MarkTypes_Values_WorkYears_MarkTypes",
                        column: x => x.workyear_marktype_id,
                        principalTable: "WorkYears_MarkTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A_Objects_EZ",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ez_content = table.Column<string>(maxLength: 500, nullable: false),
                    ez_data = table.Column<string>(type: "xml", nullable: false),
                    ez_date = table.Column<DateTime>(nullable: false),
                    ez_sigma = table.Column<string>(maxLength: 500, nullable: true),
                    object_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Objects_EZ", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_Objects_EZ_A_Objects",
                        column: x => x.object_id,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dt = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    object_id = table.Column<int>(nullable: false),
                    object_id_out = table.Column<int>(nullable: true),
                    Tag = table.Column<int>(nullable: true),
                    WorkYear = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_A_Objects",
                        column: x => x.object_id,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_A_Objects1",
                        column: x => x.object_id_out,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_WorkYears_WorkYear",
                        column: x => x.WorkYear,
                        principalTable: "WorkYears",
                        principalColumn: "WorkYear",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "S_OPT",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    activity_id = table.Column<int>(nullable: false),
                    author_id = table.Column<int>(nullable: false),
                    doc_id = table.Column<int>(nullable: true),
                    grades = table.Column<string>(type: "shortstring", nullable: true, defaultValueSql: "('')"),
                    hours = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsFrozen = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsShareable = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    LeadingFormUD = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    OrgForm = table.Column<string>(maxLength: 500, nullable: true),
                    Result = table.Column<string>(nullable: true),
                    SimpleKIM = table.Column<string>(nullable: true),
                    SimpleResources = table.Column<string>(nullable: true),
                    Target_Developing = table.Column<string>(nullable: true),
                    Target_Study = table.Column<string>(nullable: true),
                    Target_Teaching = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_OPT", x => x.uid);
                    table.ForeignKey(
                        name: "FK_S_OPT_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_S_OPT_Users",
                        column: x => x.author_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_S_OPT_A_Objects",
                        column: x => x.doc_id,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A_Objects_Validation_Results",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "('E')"),
                    descr = table.Column<string>(maxLength: 500, nullable: false),
                    validation_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Objects_Validation_Results", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_Objects_Validation_Results_A_Objects_Validation",
                        column: x => x.validation_id,
                        principalTable: "A_Objects_Validation",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "A_Tasks",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    author_id = table.Column<int>(nullable: true),
                    Data = table.Column<string>(type: "xml", nullable: true),
                    deadline = table.Column<DateTime>(nullable: false),
                    dt = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    endtime = table.Column<DateTime>(nullable: true),
                    fact_id = table.Column<int>(nullable: true),
                    failtime = table.Column<DateTime>(nullable: false),
                    hooked_object_id = table.Column<int>(nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: false),
                    paused_object_id = table.Column<int>(nullable: true),
                    receiver_id = table.Column<int>(nullable: false),
                    showtime = table.Column<DateTime>(nullable: false),
                    Tag = table.Column<int>(nullable: true),
                    Txt = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Tasks", x => x.uid);
                    table.ForeignKey(
                        name: "FK_A_Tasks_Users",
                        column: x => x.author_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Tasks_F",
                        column: x => x.fact_id,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Tasks_A_Objects",
                        column: x => x.hooked_object_id,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Tasks_A_Objects1",
                        column: x => x.paused_object_id,
                        principalTable: "A_Objects",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Tasks_Users1",
                        column: x => x.receiver_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_Results_Final",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    hours = table.Column<int>(nullable: false),
                    mark_exam = table.Column<int>(nullable: true),
                    mark_god = table.Column<int>(nullable: true),
                    mark_itog = table.Column<int>(nullable: true),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_Results_Final", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_Final_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_Final_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_Final_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_Studying_MainMarks",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    IsAbsent = table.Column<bool>(nullable: false),
                    lesson_length = table.Column<int>(nullable: false),
                    mark_type = table.Column<string>(maxLength: 50, nullable: false),
                    mark_value = table.Column<int>(nullable: true),
                    pupil_id = table.Column<int>(nullable: false),
                    time_late = table.Column<int>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_Studying_MainMarks", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_MainMarks_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_MainMarks_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_MainMarks_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_Studying_SpecialMarks",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    edu_date = table.Column<DateTime>(nullable: false),
                    lesson_volume = table.Column<int>(nullable: false),
                    mark_value = table.Column<int>(nullable: false),
                    marktype_id = table.Column<int>(nullable: false),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_Studying_SpecialMarks", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_SpecialMarks_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_SpecialMarks_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_SpecialMarks_C_MarkTypes",
                        column: x => x.marktype_id,
                        principalTable: "C_MarkTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Studying_SpecialMarks_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Experts_StudyProgram",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    expert_id = table.Column<int>(nullable: false),
                    grade = table.Column<int>(nullable: false),
                    IsActual = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Experts_StudyProgram", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Experts_StudyProgram_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Experts_StudyProgram_Users",
                        column: x => x.expert_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Experts_StudyProgram_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_Groups_Basic_Sostav",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    basicgroup_id = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Groups_Basic_Sostav", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Groups_Basic_Sostav_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Groups_Basic_Sostav_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Groups_Extra",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    Descr = table.Column<string>(maxLength: 500, nullable: true),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Groups_Extra", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Groups_Extra_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPlans",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    LessonLength = table.Column<int>(nullable: false),
                    period_id = table.Column<int>(nullable: true),
                    plan_end = table.Column<DateTime>(nullable: false),
                    plan_start = table.Column<DateTime>(nullable: false),
                    ShortWeek = table.Column<bool>(nullable: false),
                    WeekCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPlans", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_C_PeriodTypes",
                        column: x => x.period_id,
                        principalTable: "C_PeriodTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPrograms",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    essay_count = table.Column<int>(nullable: false),
                    volume = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPrograms", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_Workers",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    education_id = table.Column<int>(nullable: true),
                    IsTeacher = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    position_id = table.Column<int>(nullable: false),
                    stavka_norma = table.Column<double>(nullable: true),
                    stavka_value = table.Column<double>(nullable: true),
                    worktype_id = table.Column<int>(nullable: false),
                    worker_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Workers", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Workers_C_EducationTypes",
                        column: x => x.education_id,
                        principalTable: "C_EducationTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Workers_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Workers_S_Positions",
                        column: x => x.position_id,
                        principalTable: "S_Positions",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Workers_C_WorkTypes",
                        column: x => x.worktype_id,
                        principalTable: "C_WorkTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Workers_Users",
                        column: x => x.worker_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Workers_Teaching",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    teacher_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Workers_Teaching", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Workers_Teaching_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Workers_Teaching_C_WorkCategories",
                        column: x => x.category_id,
                        principalTable: "C_WorkCategories",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Workers_Teaching_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Workers_Teaching_Users",
                        column: x => x.teacher_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Groups_Extra_Items",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fact_id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Tag = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Groups_Extra_Items", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Groups_Extra_Items_F_Groups_Extra",
                        column: x => x.fact_id,
                        principalTable: "F_Groups_Extra",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_Groups_Extra_Sources",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    basicgroup_id = table.Column<int>(nullable: false),
                    fact_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Groups_Extra_Sources", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Groups_Extra_Sources_F_Groups_Extra",
                        column: x => x.fact_id,
                        principalTable: "F_Groups_Extra",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_Results",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    hours = table.Column<int>(nullable: false),
                    mark_main = table.Column<int>(nullable: false),
                    period_id = table.Column<int>(nullable: false),
                    plan_id = table.Column<int>(nullable: true),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_Results", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_C_PeriodTypes",
                        column: x => x.period_id,
                        principalTable: "C_PeriodTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_F_StudyPlans",
                        column: x => x.plan_id,
                        principalTable: "F_StudyPlans",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Results_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPlans_Content",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    activity_id = table.Column<int>(nullable: false),
                    grade = table.Column<int>(nullable: false),
                    hours = table.Column<double>(nullable: false),
                    plan_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPlans_Content", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_Content_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_Content_F_StudyPlans",
                        column: x => x.plan_id,
                        principalTable: "F_StudyPlans",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPlans_Nagruzka",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    grade = table.Column<int>(nullable: false),
                    hours = table.Column<double>(nullable: false),
                    plan_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPlans_Nagruzka", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_Nagruzka_F_StudyPlans",
                        column: x => x.plan_id,
                        principalTable: "F_StudyPlans",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPlans_Recepients",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    basicgroup_id = table.Column<int>(nullable: false),
                    plan_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPlans_Recepients", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPlans_Recepients_F_StudyPlans",
                        column: x => x.plan_id,
                        principalTable: "F_StudyPlans",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPrograms_Content",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fact_id = table.Column<int>(nullable: false),
                    opt_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPrograms_Content", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_Content_F_StudyPrograms",
                        column: x => x.fact_id,
                        principalTable: "F_StudyPrograms",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_Content_S_OPT",
                        column: x => x.opt_id,
                        principalTable: "S_OPT",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_Teaching",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    basicgroup_id = table.Column<int>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    essay = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    extragroup_id = table.Column<int>(nullable: true),
                    homework = table.Column<string>(maxLength: 500, nullable: false),
                    lesson_length = table.Column<int>(nullable: false),
                    teacher_id = table.Column<int>(nullable: false),
                    topic = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_Teaching", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_Teaching_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Teaching_F_Groups_Extra_Items",
                        column: x => x.extragroup_id,
                        principalTable: "F_Groups_Extra_Items",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_Teaching_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_Teaching_Users",
                        column: x => x.teacher_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Groups_Extra_Sostav",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    item_id = table.Column<int>(nullable: false),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Groups_Extra_Sostav", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Groups_Extra_Sostav_F_Groups_Extra_Items",
                        column: x => x.item_id,
                        principalTable: "F_Groups_Extra_Items",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Groups_Extra_Sostav_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyJobs",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    basicgroup_id = table.Column<int>(nullable: true),
                    dt_end = table.Column<DateTime>(nullable: true),
                    dt_start = table.Column<DateTime>(nullable: false),
                    extragroup_id = table.Column<int>(nullable: true),
                    hours = table.Column<double>(nullable: false),
                    metodist_id = table.Column<int>(nullable: false),
                    teacher_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyJobs", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyJobs_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyJobs_F_Groups_Extra_Items",
                        column: x => x.extragroup_id,
                        principalTable: "F_Groups_Extra_Items",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyJobs_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_StudyJobs_Users1",
                        column: x => x.metodist_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyJobs_Users",
                        column: x => x.teacher_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_StudyPrograms_Recepients",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    basicgroup_id = table.Column<int>(nullable: true),
                    extragroup_id = table.Column<int>(nullable: true),
                    fact_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudyPrograms_Recepients", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_Recepients_F_Groups_Extra_Items",
                        column: x => x.extragroup_id,
                        principalTable: "F_Groups_Extra_Items",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudyPrograms_Recepients_F_StudyPrograms",
                        column: x => x.fact_id,
                        principalTable: "F_StudyPrograms",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_StudySchedule",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    basicgroup_id = table.Column<int>(nullable: true),
                    classroom_id = table.Column<int>(nullable: false),
                    dt_end = table.Column<DateTime>(nullable: false),
                    dt_start = table.Column<DateTime>(nullable: false),
                    extragroup_id = table.Column<int>(nullable: true),
                    IsCancelled = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsExclusive = table.Column<bool>(nullable: false),
                    teacher_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_StudySchedule", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_StudySchedule_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudySchedule_S_Classrooms",
                        column: x => x.classroom_id,
                        principalTable: "S_Classrooms",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudySchedule_F_Groups_Extra_Items",
                        column: x => x.extragroup_id,
                        principalTable: "F_Groups_Extra_Items",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_StudySchedule_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_StudySchedule_Users",
                        column: x => x.teacher_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_CUD",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false),
                    activity_id = table.Column<int>(nullable: false),
                    cud_text = table.Column<string>(nullable: true),
                    prog_opt_id = table.Column<int>(nullable: false),
                    pupil_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_CUD", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_S_Activities",
                        column: x => x.activity_id,
                        principalTable: "S_Activities",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_F",
                        column: x => x.uid,
                        principalTable: "F",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_F_StudyPrograms_Content",
                        column: x => x.prog_opt_id,
                        principalTable: "F_StudyPrograms_Content",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_Users",
                        column: x => x.pupil_id,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "F_Education_CUD_Marks",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fact_id = table.Column<int>(nullable: false),
                    mark_value = table.Column<int>(nullable: false),
                    marktype_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Education_CUD_Marks", x => x.uid);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_Marks_F_Education_CUD",
                        column: x => x.fact_id,
                        principalTable: "F_Education_CUD",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_F_Education_CUD_Marks_C_MarkTypes",
                        column: x => x.marktype_id,
                        principalTable: "C_MarkTypes",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_author_id",
                table: "A_Objects",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_creator_id",
                table: "A_Objects",
                column: "creator_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_expert_id",
                table: "A_Objects",
                column: "expert_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_locker_session",
                table: "A_Objects",
                column: "locker_session");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_objectstate_id",
                table: "A_Objects",
                column: "objectstate_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_objectype_id",
                table: "A_Objects",
                column: "objectype_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_org_id",
                table: "A_Objects",
                column: "org_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_WorkYear",
                table: "A_Objects",
                column: "WorkYear");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_EZ_object_id",
                table: "A_Objects_EZ",
                column: "object_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_ObjectTypes_division_id",
                table: "A_ObjectTypes",
                column: "division_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_ObjectTypes_journal_id",
                table: "A_ObjectTypes",
                column: "journal_id");

            migrationBuilder.CreateIndex(
                name: "uc_Label",
                table: "A_ObjectTypes",
                column: "Label",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_A_ObjectTypes_Permissions_user_id",
                table: "A_ObjectTypes_Permissions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_ObjectTypes_Permissions",
                table: "A_ObjectTypes_Permissions",
                columns: new[] { "objectype_id", "user_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_Validation_objectstate_id",
                table: "A_Objects_Validation",
                column: "objectstate_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_Validation_session",
                table: "A_Objects_Validation",
                column: "session");

            migrationBuilder.CreateIndex(
                name: "IX_A_Objects_Validation_Results_validation_id",
                table: "A_Objects_Validation_Results",
                column: "validation_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Tasks_author_id",
                table: "A_Tasks",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Tasks_fact_id",
                table: "A_Tasks",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Tasks_hooked_object_id",
                table: "A_Tasks",
                column: "hooked_object_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Tasks_paused_object_id",
                table: "A_Tasks",
                column: "paused_object_id");

            migrationBuilder.CreateIndex(
                name: "IX_A_Tasks_receiver_id",
                table: "A_Tasks",
                column: "receiver_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_object_id",
                table: "F",
                column: "object_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_object_id_out",
                table: "F",
                column: "object_id_out");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkYear",
                table: "F",
                column: "WorkYear");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_CUD_activity_id",
                table: "F_Education_CUD",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_CUD_prog_opt_id",
                table: "F_Education_CUD",
                column: "prog_opt_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_CUD_pupil_id",
                table: "F_Education_CUD",
                column: "pupil_id");

            migrationBuilder.CreateIndex(
                name: "IX_FEducationCUD_PupilId",
                table: "F_Education_CUD",
                columns: new[] { "uid", "activity_id", "prog_opt_id", "cud_text", "pupil_id" });

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_CUD_Marks_fact_id",
                table: "F_Education_CUD_Marks",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_FEducationCUDMarks_FactId",
                table: "F_Education_CUD_Marks",
                columns: new[] { "marktype_id", "mark_value", "fact_id" });

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results_activity_id",
                table: "F_Education_Results",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results_period_id",
                table: "F_Education_Results",
                column: "period_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results_plan_id",
                table: "F_Education_Results",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results",
                table: "F_Education_Results",
                columns: new[] { "pupil_id", "activity_id", "period_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results_Final_activity_id",
                table: "F_Education_Results_Final",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Results_Final_pupil_id",
                table: "F_Education_Results_Final",
                column: "pupil_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Studying_MainMarks_activity_id",
                table: "F_Education_Studying_MainMarks",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_Education_Studying_MainMarks_PupilId_IsAbsent_DtStart",
                table: "F_Education_Studying_MainMarks",
                columns: new[] { "pupil_id", "IsAbsent", "dt_start" });

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Studying_SpecialMarks_activity_id",
                table: "F_Education_Studying_SpecialMarks",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Studying_SpecialMarks_marktype_id",
                table: "F_Education_Studying_SpecialMarks",
                column: "marktype_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Studying_SpecialMarks_pupil_id",
                table: "F_Education_Studying_SpecialMarks",
                column: "pupil_id");

            migrationBuilder.CreateIndex(
                name: "IX_FEducationStudyingSpecialMarks_PupilId_EduDate",
                table: "F_Education_Studying_SpecialMarks",
                columns: new[] { "lesson_volume", "activity_id", "marktype_id", "mark_value", "pupil_id", "edu_date" });

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Teaching_activity_id",
                table: "F_Education_Teaching",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Teaching_extragroup_id",
                table: "F_Education_Teaching",
                column: "extragroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Teaching_teacher_id",
                table: "F_Education_Teaching",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Education_Teaching_ActivityId_DtStart",
                table: "F_Education_Teaching",
                columns: new[] { "dt_start", "activity_id" });

            migrationBuilder.CreateIndex(
                name: "IX_F_Experts_StudyProgram_activity_id",
                table: "F_Experts_StudyProgram",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Experts_StudyProgram_expert_id",
                table: "F_Experts_StudyProgram",
                column: "expert_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Groups_Basic_Sostav_pupil_id",
                table: "F_Groups_Basic_Sostav",
                column: "pupil_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Groups_Extra_Items_fact_id",
                table: "F_Groups_Extra_Items",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Groups_Extra_Sostav_item_id",
                table: "F_Groups_Extra_Sostav",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Groups_Extra_Sostav_pupil_id",
                table: "F_Groups_Extra_Sostav",
                column: "pupil_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Groups_Extra_Sources_fact_id",
                table: "F_Groups_Extra_Sources",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyJobs_activity_id",
                table: "F_StudyJobs",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyJobs_extragroup_id",
                table: "F_StudyJobs",
                column: "extragroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyJobs_metodist_id",
                table: "F_StudyJobs",
                column: "metodist_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyJobs_teacher_id",
                table: "F_StudyJobs",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPlans_period_id",
                table: "F_StudyPlans",
                column: "period_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPlans_Content_activity_id",
                table: "F_StudyPlans_Content",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPlans_Content_plan_id",
                table: "F_StudyPlans_Content",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPlans_Nagruzka_plan_id",
                table: "F_StudyPlans_Nagruzka",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPlans_Recepients_plan_id",
                table: "F_StudyPlans_Recepients",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPrograms_activity_id",
                table: "F_StudyPrograms",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPrograms_Content_fact_id",
                table: "F_StudyPrograms_Content",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPrograms_Content_opt_id",
                table: "F_StudyPrograms_Content",
                column: "opt_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPrograms_Recepients_extragroup_id",
                table: "F_StudyPrograms_Recepients",
                column: "extragroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudyPrograms_Recepients_fact_id",
                table: "F_StudyPrograms_Recepients",
                column: "fact_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudySchedule_activity_id",
                table: "F_StudySchedule",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudySchedule_classroom_id",
                table: "F_StudySchedule",
                column: "classroom_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudySchedule_extragroup_id",
                table: "F_StudySchedule",
                column: "extragroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_StudySchedule_teacher_id",
                table: "F_StudySchedule",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_education_id",
                table: "F_Workers",
                column: "education_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_position_id",
                table: "F_Workers",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_worktype_id",
                table: "F_Workers",
                column: "worktype_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_worker_id",
                table: "F_Workers",
                column: "worker_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_Teaching_activity_id",
                table: "F_Workers_Teaching",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_Teaching_category_id",
                table: "F_Workers_Teaching",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Workers_Teaching_teacher_id",
                table: "F_Workers_Teaching",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_S_Activities_type_id",
                table: "S_Activities",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_S_OPT_activity_id",
                table: "S_OPT",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_S_OPT_author_id",
                table: "S_OPT",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_S_OPT_doc_id",
                table: "S_OPT",
                column: "doc_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Parentship_child_id",
                table: "Users_Parentship",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Parentship_parent_id",
                table: "Users_Parentship",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Sessions",
                table: "Users_Sessions",
                column: "session",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Sessions_user_id",
                table: "Users_Sessions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkYears_Groups_Basic_WorkYear",
                table: "WorkYears_Groups_Basic",
                column: "WorkYear");

            migrationBuilder.CreateIndex(
                name: "IX_WorkYears_MarkTypes_marktype_id",
                table: "WorkYears_MarkTypes",
                column: "marktype_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkYears_MarkTypes_WorkYear",
                table: "WorkYears_MarkTypes",
                column: "WorkYear");

            migrationBuilder.CreateIndex(
                name: "IX_WorkYears_MarkTypes_Values",
                table: "WorkYears_MarkTypes_Values",
                columns: new[] { "workyear_marktype_id", "value_int" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_Objects_EZ");

            migrationBuilder.DropTable(
                name: "A_ObjectTypes_Permissions");

            migrationBuilder.DropTable(
                name: "A_Objects_Validation_Results");

            migrationBuilder.DropTable(
                name: "A_Tasks");

            migrationBuilder.DropTable(
                name: "A_Variables");

            migrationBuilder.DropTable(
                name: "F_Education_CUD_Marks");

            migrationBuilder.DropTable(
                name: "F_Education_Results");

            migrationBuilder.DropTable(
                name: "F_Education_Results_Final");

            migrationBuilder.DropTable(
                name: "F_Education_Studying_MainMarks");

            migrationBuilder.DropTable(
                name: "F_Education_Studying_SpecialMarks");

            migrationBuilder.DropTable(
                name: "F_Education_Teaching");

            migrationBuilder.DropTable(
                name: "F_Experts_StudyProgram");

            migrationBuilder.DropTable(
                name: "F_Groups_Basic_Sostav");

            migrationBuilder.DropTable(
                name: "F_Groups_Extra_Sostav");

            migrationBuilder.DropTable(
                name: "F_Groups_Extra_Sources");

            migrationBuilder.DropTable(
                name: "F_StudyJobs");

            migrationBuilder.DropTable(
                name: "F_StudyPlans_Content");

            migrationBuilder.DropTable(
                name: "F_StudyPlans_Nagruzka");

            migrationBuilder.DropTable(
                name: "F_StudyPlans_Recepients");

            migrationBuilder.DropTable(
                name: "F_StudyPrograms_Recepients");

            migrationBuilder.DropTable(
                name: "F_StudySchedule");

            migrationBuilder.DropTable(
                name: "F_Workers");

            migrationBuilder.DropTable(
                name: "F_Workers_Teaching");

            migrationBuilder.DropTable(
                name: "SiteDocuments");

            migrationBuilder.DropTable(
                name: "Users_Organizer");

            migrationBuilder.DropTable(
                name: "Users_Parentship");

            migrationBuilder.DropTable(
                name: "WorkYears_Groups_Basic");

            migrationBuilder.DropTable(
                name: "WorkYears_MarkTypes_Values");

            migrationBuilder.DropTable(
                name: "A_Objects_Validation");

            migrationBuilder.DropTable(
                name: "F_Education_CUD");

            migrationBuilder.DropTable(
                name: "F_StudyPlans");

            migrationBuilder.DropTable(
                name: "S_Classrooms");

            migrationBuilder.DropTable(
                name: "F_Groups_Extra_Items");

            migrationBuilder.DropTable(
                name: "C_EducationTypes");

            migrationBuilder.DropTable(
                name: "S_Positions");

            migrationBuilder.DropTable(
                name: "C_WorkTypes");

            migrationBuilder.DropTable(
                name: "C_WorkCategories");

            migrationBuilder.DropTable(
                name: "WorkYears_MarkTypes");

            migrationBuilder.DropTable(
                name: "F_StudyPrograms_Content");

            migrationBuilder.DropTable(
                name: "C_PeriodTypes");

            migrationBuilder.DropTable(
                name: "F_Groups_Extra");

            migrationBuilder.DropTable(
                name: "C_MarkTypes");

            migrationBuilder.DropTable(
                name: "F_StudyPrograms");

            migrationBuilder.DropTable(
                name: "S_OPT");

            migrationBuilder.DropTable(
                name: "F");

            migrationBuilder.DropTable(
                name: "S_Activities");

            migrationBuilder.DropTable(
                name: "A_Objects");

            migrationBuilder.DropTable(
                name: "C_ActivityTypes");

            migrationBuilder.DropTable(
                name: "Users_Sessions");

            migrationBuilder.DropTable(
                name: "C_ObjectStates");

            migrationBuilder.DropTable(
                name: "A_ObjectTypes");

            migrationBuilder.DropTable(
                name: "S_Organizations");

            migrationBuilder.DropTable(
                name: "WorkYears");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "C_Divisions");

            migrationBuilder.DropTable(
                name: "A_ObjectTypes_Journals");
        }
    }
}
