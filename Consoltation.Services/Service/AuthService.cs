using Consultation.Service.IService;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Consultation.Repository.IRepository;
using Consultation.Repository;
using Consultation.Domain.Enum;
using Consultation.Repository.Repository.IRepository;


namespace Consultation.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _userRepository;
        private readonly PasswordHasher<Users> _passwordHasher;
        private Users? user;
        public string AdminUserID { get; set; }
      

        public AuthService(AppDbContext context)
        {
            _passwordHasher = new PasswordHasher<Users>();
            _userRepository = new UserRepository(context);

        }

        //This authenticate user account
        public async Task<Users?> Login(string email, string password,string role)
        {
            user = await _userRepository.GetUserByEmail(email);
            if (user == null)
                return null;

            var userFilter = role switch
            {
                "Admin" => user.UserType.ToString() == UserType.Admin.ToString(),
                "Faculty" => user.UserType.ToString() == UserType.Faculty.ToString(),
                "Student" => user.UserType.ToString() == UserType.Student.ToString(),
                _ => false
            };

            if (!userFilter)
                return null;

           var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
           return result == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success ? user : null;
        }

        //This is for mobile, to get the needed student information
        public async Task<Student?> GetStudentInformation(string studentUMID)
        {
            return await _userRepository.GetStudentInformation(studentUMID);
        }   
    }
}
