
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Consultation.Repository;
using Consultation.Repository.Repository.IRepository;
using Consultation.Service;
using Consultation.Service.IService;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace consultation.Testing
{
    public class Program
    {
        private readonly ServiceProvider _provider;
        private readonly IAuthService authServices;
        public async static Task Main(string[] args)
        {
            Program p = new Program();
            //await p.LogInTest();
            await p.GetConsultationRequestTest();
            //p.Test();
        }




        public Program()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(o =>
            o.UseSqlServer("Server=tcp:consultationserver.database.windows.net,1433;" +
                "Initial Catalog=ConsultationDatabase;" +
                "Persist Security Info=False;" +
                "User ID=ConsultationDB;" +
                "Password=MyServerAdmin123!;" +
                "MultipleActiveResultSets=False;" +
                "Encrypt=True;" +
                "TrustServerCertificate=False;" +
                "Connection Timeout=30;"));
            services.AddScoped<IAuthRepository, UserRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IConsultationRequestServices, ConsultationRequestServices>();
            services.AddScoped<IPasswordHasher<Users>, PasswordHasher<Users>>();
         
            _provider = services.BuildServiceProvider();
            authServices = _provider.GetRequiredService<IAuthService>();
        }
      
        /*
         * Username: CedricSetimo.550200@umindanao.edu.ph 
         * Password: MyStudent123!
         * Role: Student
         */
        private async Task LogInTest()
        {
            Users user = await authServices.Login("CedricSetimo.550200@umindanao.edu.ph", "MyStudent123!", "Student");

            Console.WriteLine($"Username: {user.UserName}");
            Console.WriteLine($"Id: {user.Id}");
            Console.WriteLine($"UMID: {user.UMID}");
        }

        private async Task<Student> GetStudentInfomation(Users users)
        {
            return await authServices.GetStudentInformation(users.UMID);
        }

        private async Task GetConsultationRequestTest()
        {
            Users user = await authServices.Login("CedricSetimo.550200@umindanao.edu.ph", "MyStudent123!", "Student");


            //Get the student first 
            Student student = await GetStudentInfomation(user);

            //Display the student enrolled courses information 
            //foreach(var x in student.SchoolYear.EnrolledCourses)
            //{
            //    Console.WriteLine($"Course Name: {x.CourseName}");
            //}
            Console.WriteLine(student.Program.Description);
            
        }

        //Coding practice 

        public void Test()
        {
            string word = "Allen Vincent Naive";
            string[] split = word.Split(' ');
            List<string> wordSplit = new List<string>();
            foreach (var i in split)
            {
                wordSplit.Add(i);
            }
            string lastname = split[split.Length-1];
            string name = string.Empty;

            for(int i =0;i< wordSplit.Count - 1; i++)
            {
                name += split[i] + " ";
            }

            Console.WriteLine($"{lastname},{name.Trim()} ");

        }


    }

}



