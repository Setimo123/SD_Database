using Consultation.Domain.Enum;
using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;

namespace Consultation.Infrastructure.Data
{
    public class DatabaseSeederInfo
    {
        public static List<Users> UserDataList()
        {
            var users = new List<Users>
            {
            DatabaseSeeder.UserSeeder("273F528F-5330-411F-9C6B-01543D6249C3", "550200", "Cedric Setimo", "CedricSetimo.550200@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("53D8F920-EBEC-4DF3-8C53-21F6D123F0D9", "321033", "Rey Mateo", "ReyMateo.550200@umindanao.edu.ph", "MyFaculty123!", Domain.Enum.UserType.Faculty),
            DatabaseSeeder.UserSeeder("6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF", "444533", "Raine Isid", "RaineIsid.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Admin),
            DatabaseSeeder.UserSeeder("D0B26692-E380-4374-985F-239B56D06C20", "547343", "Ellaine Musni", "EllaineMusni.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("1226920F-9508-44B3-845A-ABABBBCBCF5D", "685043", "Reggie Soylon", "ReggieSoylon.6850@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("0A52E15B-95E6-40FE-9110-9A44817BFF39", "899812", "Cheley Balsomo", "CheleyBalsomo.8998@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("78B4AF2A-672F-43C5-B819-5F0B407B7187", "797132", "Jeanelle Labsan", "JeanelleLabsan.7971@umindanao.edu.ph", "MyFaculty123!", Domain.Enum.UserType.Faculty),
            DatabaseSeeder.UserSeeder("59CF8531-68E4-466B-BAEC-45305FE16A14", "924132", "Christopher Destajo", "ChristopherDestajo.9241@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("D81B4D15-B3CD-47D5-96B0-44EF8E39E538", "54321", "Jiver Dejiga", "JiverDejiga.3210@umindanao.edu.ph", "Admin", Domain.Enum.UserType.Admin),
            };

            return users;
        }
        //<Guid("D81B4D15-B3CD-47D5-96B0-44EF8E39E538")>

        public static List<Department> DeparrmentDataList()
        {
            var departments = new List<Department>
            {
                DatabaseSeeder.DepartmentSeeder(1, "CASE", "College of Arts and Sciences Education"),
                DatabaseSeeder.DepartmentSeeder(2, "CBAE", "College of Business Administration Education"),
                DatabaseSeeder.DepartmentSeeder(3, "CEE", "College of Engineering Education")
            };
            return departments;
        }

        public static List<Program> ProgramDataList()
        {

            var program = new List<Program>
            {
                DatabaseSeeder.ProgramSeeder(1, "ME", "Mechanical Engineering",3),
                DatabaseSeeder.ProgramSeeder(2, "CE", "Civil Engineering",3),
                DatabaseSeeder.ProgramSeeder(3, "CPE", "Computer Engineering",3),
                DatabaseSeeder.ProgramSeeder(4, "EE", "Electrical Engineering",3),
                DatabaseSeeder.ProgramSeeder(5, "ECE", "Electronics Engineering",3),
            };
            return program;
        }

        public static List<SchoolYear> SchoolYearDataList()
        {

            var schoolYears = new List<SchoolYear>
            {
                DatabaseSeeder.schoolYearSeeder(1,"2024","2025",Domain.Enum.Semester.Semester1,Domain.Enum.SchoolYearStatus.Current),
                DatabaseSeeder.schoolYearSeeder(2,"2024","2025",Domain.Enum.Semester.Semester2,Domain.Enum.SchoolYearStatus.Current),
                DatabaseSeeder.schoolYearSeeder(3,"2024","2025",Domain.Enum.Semester.Summer,Domain.Enum.SchoolYearStatus.Current),
            };
            return schoolYears;
        }

        public static List<EnrolledCourse> EnrolledCourseDataList()
        {

            var enrolledCourses = new List<EnrolledCourse>
            {
                //Enrolled courses in first semester
                DatabaseSeeder.EnrollCourseSeeder(1,"Engineering Calculus 1", "CEE101", 1, 1, 1,"ECE"),
                DatabaseSeeder.EnrollCourseSeeder(2,"PHYSICS 1 FOR ENGINEERS (CALCULUS BASED)", "CEE102/L", 1, 1, 2,"CE"),
                DatabaseSeeder.EnrollCourseSeeder(3,"Statics of Rigid Bodies", "CEE108", 1, 1, 2, "CE"),
                DatabaseSeeder.EnrollCourseSeeder(4,"Statics of Rigid Bodies", "CEE108", 1, 2, 2, "ME"),
             
                //Enrolled courses in second semester
                DatabaseSeeder.EnrollCourseSeeder(5,"Engineering Calculus 2", "CEE103", 2, 1, 2, "CHE"),
                DatabaseSeeder.EnrollCourseSeeder(6,"Thermodyanmics 2", "CEE101", 2, 1, 1, "ME"),
                 DatabaseSeeder.EnrollCourseSeeder(7,"Data Structure and Algorithms", "CPE221/L", 2, 1, 2, "CPE"),

                //Enrolled courses in summer
                DatabaseSeeder.EnrollCourseSeeder(8,"Differential Equation", "CEE104", 3, 1, 2, "EE"),
            };
            return enrolledCourses;
        }


        public static List<Student> StudentDataList()
        {

            var students = new List<Student>
            {
                DatabaseSeeder.StudentSeeder(1,"550200","Cedric Setimo","CedricSetimo.550200@umindanao.edu.ph",3,1,
                "273F528F-5330-411F-9C6B-01543D6249C3",YearLevel.Third_Year),
                 DatabaseSeeder.StudentSeeder(2,"547343","Ellaine Musni","EllaineMusni.550200@umindanao.edu.ph",3,1,
                "D0B26692-E380-4374-985F-239B56D06C20",YearLevel.Third_Year),
            };
            return students;
        }

        public static List<Faculty> FacultyDataList()
        {

            var faculty = new List<Faculty>()
            {
                DatabaseSeeder.FacultySeeder(1, "321033", "Rey Mateo", 1,"53D8F920-EBEC-4DF3-8C53-21F6D123F0D9"),
                DatabaseSeeder.FacultySeeder(2, "797132", "Jeanelle Labsan",2,"78B4AF2A-672F-43C5-B819-5F0B407B7187"),
            };
            return faculty;
        }


        public static List<Admin> AdminDataList()
        {


            var admin = new List<Admin>()
            {
                DatabaseSeeder.AdminSeeder(1, "Raine Isid", "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF"),
                DatabaseSeeder.AdminSeeder(2, "Jiver Dejiga", "D81B4D15-B3CD-47D5-96B0-44EF8E39E538"),
            };
            return admin;
        }

        public static List<ConsultationRequest> ConsultationRequestDataList()
        {


            var consultationRequest = new List<ConsultationRequest>()
            {
                   DatabaseSeeder.ConsultationRequestSeeder(
                    1,
                    new DateTime(2025, 07, 20),
                    new DateTime(2025, 07, 25),
                    new TimeOnly(9, 0),
                    new TimeOnly(10, 0),
                    "Need help with calculus problems",
                    null,
                    "MATH101",
                    Status.Pending,
                    "ME",
                    1,
                    1
                ),

                DatabaseSeeder.ConsultationRequestSeeder(
                    2,
                    new DateTime(2025, 07, 21),
                    new DateTime(2025, 07, 26),
                    new TimeOnly(13, 30),
                    new TimeOnly(14, 30),
                    "Need help with data structures",
                    null,
                    "CS202",
                    Status.Pending,
                    "CPE",
                    2,
                    1
                ),
                DatabaseSeeder.ConsultationRequestSeeder(
                    3,
                    new DateTime(2025, 07, 19),
                    new DateTime(2025, 07, 28),
                    new TimeOnly(15, 0),
                    new TimeOnly(16, 0),
                    "Follow-up on previous consultation",
                    "Faculty unavailable",
                    "PHY303",
                    Status.Disapproved,
                    "CE",
                    1,
                    2
                ),
            };
            return consultationRequest;
        }

        public static List<FacultySchedule> FacultyScheduleSeeder()
        {
            var faucltySchedule = new List<FacultySchedule>()
            {
            DatabaseSeeder.FacultyScheduleSeeder(1, new TimeOnly(15, 0), new TimeOnly(16, 0),DaysOfWeek.Monday,1),
            DatabaseSeeder.FacultyScheduleSeeder(2, new TimeOnly(11, 0), new TimeOnly(12, 0),DaysOfWeek.Friday,2),
            DatabaseSeeder.FacultyScheduleSeeder(3, new TimeOnly(14, 0), new TimeOnly(15, 0), DaysOfWeek.Tuesday, 1),
            };
            return faucltySchedule;
        }

        public static List<Notification> NotificationSeeder()
        {
            var notification = new List<Notification>()
            {
            DatabaseSeeder.NotificationSeeder(1, "Hello World",NotificationType.StudentNotification),
            DatabaseSeeder.NotificationSeeder(2, "Hi World",NotificationType.AdminNotification),
            DatabaseSeeder.NotificationSeeder(3, "Jiver Gwapo",NotificationType.StudentNotification),
            };
            return notification;
        }

        public static List<Bulletin> BulletinSeeder()
        {
            var notification = new List<Bulletin>()
            {
               DatabaseSeeder.BulletinSeeder(1, "Welcome Week Schedule", "Student Affairs",
                     BulletinStatus.publish, new DateTime(2025, 8, 1), 2, false),

              DatabaseSeeder.BulletinSeeder(2, "Maintenance Downtime", "IT",
                    BulletinStatus.publish, new DateTime(2025, 8, 5), 1, false),

              DatabaseSeeder.BulletinSeeder(3, "New Library Hours", "Library",
                    BulletinStatus.pending, new DateTime(2025, 8, 7), 0, false),

         DatabaseSeeder.BulletinSeeder(4, "Policy Archive", "Admin",
                    BulletinStatus.pending, new DateTime(2024, 12, 1), 3, true),

            };
            return notification;
        }
    }
}
