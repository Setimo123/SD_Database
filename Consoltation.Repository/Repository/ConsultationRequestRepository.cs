using Consultation.App.Repository.IRepository;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Consultation.App.Repository
{
    public class ConsultationRequestRepository : IConsultationRequestRepository
    {
        private readonly AppDbContext _context;

        public ConsultationRequestRepository(AppDbContext context) => _context = context;

        public async Task<List<ConsultationRequest>> GetConsultation(string ProgramName)
        {
            try
            {
                var ConsultationRequestList = await _context.ConsultationRequest.Where(x => x.ProgramName == ProgramName)
                    .ToListAsync();
                return ConsultationRequestList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ConsultationRequestRepository Error: {ex.Message}");
                return null;
            }
        }

        public async Task<ConsultationRequest?> GetStudenInfoConsultationRequests(int studentId)
        {
            return await _context.ConsultationRequest
                                .Include(c => c.Student)
                                .FirstOrDefaultAsync(c => c.StudentID == studentId);
        }

        public async Task<ConsultationRequest?> GetFacultyaInfoConsultationRequests(int facultyId)
        {
            return await _context.ConsultationRequest
                                 .Include(c => c.Faculty)
                                 .FirstOrDefaultAsync(c => c.FacultyID == facultyId);
        }

        
        public async Task<List<ConsultationRequest>> GetConsultationRequestInfo(string programName)
        {
            return await _context.ConsultationRequest
                                 .Include(c => c.Student)
                                 .Include(c => c.Faculty)
                                 .Where(c => c.ProgramName == programName)
                                 .ToListAsync();
        }

        public Task<Student> GetStudentInformation(string studentUMNumber)
        {
            throw new NotImplementedException();
        }
    }
}
