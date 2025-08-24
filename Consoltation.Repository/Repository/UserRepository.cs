using Consultation.Repository.IRepository;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Consultation.Repository.Repository.IRepository;

namespace Consultation.Repository
{
    public class UserRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) => _context = context;

        public async Task<Users?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        //For mobile repository
        public async Task<Student> GetStudentInformation(string studentUMNumber)
        {
            try
            {
                var students = _context.Students
                       .Include(s => s.SchoolYear)
                       .ThenInclude(s => s.EnrolledCourses)
                       .Include(s => s.ConsultationRequests)
                       .Include(s => s.Program)
                       .Where(s => s.StudentUMID == studentUMNumber)
                       .FirstOrDefaultAsync();
                return await students;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Student Repository Error: {ex.Message}");
                return new Student();
            }

        }
    }
}
