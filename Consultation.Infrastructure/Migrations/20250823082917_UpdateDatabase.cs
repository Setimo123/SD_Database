using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UMID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bulletin",
                columns: table => new
                {
                    BulletinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileCount = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulletin", x => x.BulletinID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationNumber);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    SchoolYearID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolYearStatus = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.SchoolYearID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionLog",
                columns: table => new
                {
                    ActionLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionLog", x => x.ActionLogID);
                    table.ForeignKey(
                        name: "FK_ActionLog_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admin_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_Program_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    FacultyUMID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyID);
                    table.ForeignKey(
                        name: "FK_Faculty_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faculty_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    StudentUMID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearLevel = table.Column<int>(type: "int", nullable: false),
                    ProgramID = table.Column<int>(type: "int", nullable: false),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Program_ProgramID",
                        column: x => x.ProgramID,
                        principalTable: "Program",
                        principalColumn: "ProgramID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacultySchedule",
                columns: table => new
                {
                    FacultyScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    TimeEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySchedule", x => x.FacultyScheduleID);
                    table.ForeignKey(
                        name: "FK_FacultySchedule_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultationRequest",
                columns: table => new
                {
                    ConsultationID = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSchedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndedTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Concern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisapprovedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationRequest", x => x.ConsultationID);
                    table.ForeignKey(
                        name: "FK_ConsultationRequest_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID");
                    table.ForeignKey(
                        name: "FK_ConsultationRequest_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "EnrolledCourse",
                columns: table => new
                {
                    EnrolledCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    ProgramCourse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolledCourse", x => x.EnrolledCourseID);
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID");
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UMID", "UserName", "UserType" },
                values: new object[,]
                {
                    { "0A52E15B-95E6-40FE-9110-9A44817BFF39", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "CheleyBalsomo.8998@umindanao.edu.ph", true, false, null, "CHELEYBALSOMO.8998@UMINDANAO.EDU.PH", "CHELEY BALSOMO", "AQAAAAIAAYagAAAAEKAJ7pl/JUtpkjeYKrBUCbWUq0IBSR5Hp9JJlYyVI48QzJWpPveqHdMSPryoZRCsUg==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "899812", "Cheley Balsomo", 1 },
                    { "1226920F-9508-44B3-845A-ABABBBCBCF5D", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ReggieSoylon.6850@umindanao.edu.ph", true, false, null, "REGGIESOYLON.6850@UMINDANAO.EDU.PH", "REGGIE SOYLON", "AQAAAAIAAYagAAAAEH2GbUo8bImhCP+5FDkqWi+SRBeIYU02tE3bddidi2n92N38l1lvfmCxRx8sy6/5iQ==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "685043", "Reggie Soylon", 1 },
                    { "273F528F-5330-411F-9C6B-01543D6249C3", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "CedricSetimo.550200@umindanao.edu.ph", true, false, null, "CEDRICSETIMO.550200@UMINDANAO.EDU.PH", "CEDRIC SETIMO", "AQAAAAIAAYagAAAAEBpFpxhcO+oGFdQHDTjhfiSWMjDkoVfCLYt6zjvaec62HtNP2BHcgxRNTvbGQjxNsw==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "550200", "Cedric Setimo", 1 },
                    { "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ReyMateo.550200@umindanao.edu.ph", true, false, null, "REYMATEO.550200@UMINDANAO.EDU.PH", "REY MATEO", "AQAAAAIAAYagAAAAEFc5T8AB2j3RJuyxDsH/NTtR8eLMUUdCVp1BxFEdMaFNwSQrLA4tbushLcSnOaq40Q==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "321033", "Rey Mateo", 2 },
                    { "59CF8531-68E4-466B-BAEC-45305FE16A14", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ChristopherDestajo.9241@umindanao.edu.ph", true, false, null, "CHRISTOPHERDESTAJO.9241@UMINDANAO.EDU.PH", "CHRISTOPHER DESTAJO", "AQAAAAIAAYagAAAAEG4Cz2oR9CA53gtmJQWOXFJEfwJj1Y7Sg/RfB7nMjWwtplVCnVEBQLld62VOiT1r6A==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "924132", "Christopher Destajo", 1 },
                    { "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "RaineIsid.550200@umindanao.edu.ph", true, false, null, "RAINEISID.550200@UMINDANAO.EDU.PH", "RAINE ISID", "AQAAAAIAAYagAAAAECNPE/g90an2KTeOAx8jjD0KHZnAJ7YLW7eFR80p/VavRi899BqhOKsnDibcVa9YQw==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "444533", "Raine Isid", 3 },
                    { "78B4AF2A-672F-43C5-B819-5F0B407B7187", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "JeanelleLabsan.7971@umindanao.edu.ph", true, false, null, "JEANELLELABSAN.7971@UMINDANAO.EDU.PH", "JEANELLE LABSAN", "AQAAAAIAAYagAAAAEIIUO1s0Y8sFNQTs6fleb2YhVROEgs7k+7NYusrbe9eVsovGzQku+oaeTcLygt7iKA==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "797132", "Jeanelle Labsan", 2 },
                    { "D0B26692-E380-4374-985F-239B56D06C20", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "EllaineMusni.550200@umindanao.edu.ph", true, false, null, "ELLAINEMUSNI.550200@UMINDANAO.EDU.PH", "ELLAINE MUSNI", "AQAAAAIAAYagAAAAEB+p/oDNP4viNUVa6ImpYx54InkOm5irOL0cjNiEjCfCBwxuqve2YBLirK7anMGJGA==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "547343", "Ellaine Musni", 1 },
                    { "D81B4D15-B3CD-47D5-96B0-44EF8E39E538", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "JiverDejiga.3210@umindanao.edu.ph", true, false, null, "JIVERDEJIGA.3210@UMINDANAO.EDU.PH", "JIVER DEJIGA", "AQAAAAIAAYagAAAAEF1htZwIXchKXvM0LT9ZV++F+zQjP9woxHWB6DagTyVIlrUyJDXcxV7JUNrRljn5rw==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "54321", "Jiver Dejiga", 3 }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "DepartmentName", "Description" },
                values: new object[,]
                {
                    { 1, "CASE", "College of Arts and Sciences Education" },
                    { 2, "CBAE", "College of Business Administration Education" },
                    { 3, "CEE", "College of Engineering Education" }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "NotificationNumber", "NotificationMessage", "NotificationType" },
                values: new object[,]
                {
                    { 1, "Hello World", 1 },
                    { 2, "Hi World", 2 },
                    { 3, "Jiver Gwapo", 1 }
                });

            migrationBuilder.InsertData(
                table: "SchoolYear",
                columns: new[] { "SchoolYearID", "SchoolYearStatus", "Semester", "Year1", "Year2" },
                values: new object[,]
                {
                    { 1, 1, 1, "2024", "2025" },
                    { 2, 1, 2, "2024", "2025" },
                    { 3, 1, 3, "2024", "2025" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminName", "UsersID" },
                values: new object[,]
                {
                    { 1, "Raine Isid", "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF" },
                    { 2, "Jiver Dejiga", "D81B4D15-B3CD-47D5-96B0-44EF8E39E538" }
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "FacultyID", "FacultyName", "FacultyUMID", "SchoolYearID", "UsersID" },
                values: new object[,]
                {
                    { 1, "Rey Mateo", "321033", 1, "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9" },
                    { 2, "Jeanelle Labsan", "797132", 2, "78B4AF2A-672F-43C5-B819-5F0B407B7187" }
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "ProgramID", "DepartmentID", "Description", "ProgramName" },
                values: new object[,]
                {
                    { 1, 3, "Mechanical Engineering", "ME" },
                    { 2, 3, "Civil Engineering", "CE" },
                    { 3, 3, "Computer Engineering", "CPE" },
                    { 4, 3, "Electrical Engineering", "EE" },
                    { 5, 3, "Electronics Engineering", "ECE" }
                });

            migrationBuilder.InsertData(
                table: "FacultySchedule",
                columns: new[] { "FacultyScheduleID", "Day", "FacultyID", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeOnly(16, 0, 0), new TimeOnly(15, 0, 0) },
                    { 2, 5, 2, new TimeOnly(12, 0, 0), new TimeOnly(11, 0, 0) },
                    { 3, 2, 1, new TimeOnly(15, 0, 0), new TimeOnly(14, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Email", "ProgramID", "SchoolYearID", "StudentName", "StudentUMID", "UsersID", "yearLevel" },
                values: new object[,]
                {
                    { 1, "CedricSetimo.550200@umindanao.edu.ph", 3, 1, "Cedric Setimo", "550200", "273F528F-5330-411F-9C6B-01543D6249C3", 3 },
                    { 2, "EllaineMusni.550200@umindanao.edu.ph", 3, 1, "Ellaine Musni", "547343", "D0B26692-E380-4374-985F-239B56D06C20", 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsultationRequest",
                columns: new[] { "ConsultationID", "Concern", "DateRequested", "DateSchedule", "DisapprovedReason", "EndedTime", "FacultyID", "ProgramName", "StartedTime", "Status", "StudentID", "SubjectCode" },
                values: new object[,]
                {
                    { 1, "Need help with calculus problems", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeOnly(10, 0, 0), 1, "ME", new TimeOnly(9, 0, 0), 1, 1, "MATH101" },
                    { 2, "Need help with data structures", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeOnly(14, 30, 0), 1, "CPE", new TimeOnly(13, 30, 0), 1, 2, "CS202" },
                    { 3, "Follow-up on previous consultation", new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faculty unavailable", new TimeOnly(16, 0, 0), 2, "CE", new TimeOnly(15, 0, 0), 3, 1, "PHY303" }
                });

            migrationBuilder.InsertData(
                table: "EnrolledCourse",
                columns: new[] { "EnrolledCourseID", "CourseCode", "CourseName", "FacultyID", "ProgramCourse", "SchoolYearID", "StudentID" },
                values: new object[,]
                {
                    { 1, "CEE101", "Engineering Calculus 1", 1, "ECE", 1, 1 },
                    { 2, "CEE102/L", "PHYSICS 1 FOR ENGINEERS (CALCULUS BASED)", 2, "CE", 1, 1 },
                    { 3, "CEE108", "Statics of Rigid Bodies", 2, "CE", 1, 1 },
                    { 4, "CEE108", "Statics of Rigid Bodies", 2, "ME", 1, 2 },
                    { 5, "CEE103", "Engineering Calculus 2", 2, "CHE", 2, 1 },
                    { 6, "CEE101", "Thermodyanmics 2", 1, "ME", 2, 1 },
                    { 7, "CPE221/L", "Data Structure and Algorithms", 2, "CPE", 2, 1 },
                    { 8, "CEE104", "Differential Equation", 2, "EE", 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionLog_UsersId",
                table: "ActionLog",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UsersID",
                table: "Admin",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRequest_FacultyID",
                table: "ConsultationRequest",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRequest_StudentID",
                table: "ConsultationRequest",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_FacultyID",
                table: "EnrolledCourse",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_SchoolYearID",
                table: "EnrolledCourse",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_StudentID",
                table: "EnrolledCourse",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SchoolYearID",
                table: "Faculty",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UsersID",
                table: "Faculty",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_FacultySchedule_FacultyID",
                table: "FacultySchedule",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Program_DepartmentID",
                table: "Program",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgramID",
                table: "Students",
                column: "ProgramID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolYearID",
                table: "Students",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UsersID",
                table: "Students",
                column: "UsersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionLog");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bulletin");

            migrationBuilder.DropTable(
                name: "ConsultationRequest");

            migrationBuilder.DropTable(
                name: "EnrolledCourse");

            migrationBuilder.DropTable(
                name: "FacultySchedule");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
