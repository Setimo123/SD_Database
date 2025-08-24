using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Repository.IRepository
{
    public interface IConsultationRequestRepository
    {
        Task<List<ConsultationRequest>> GetConsultation(string ProgramName);

        Task<ConsultationRequest?> GetStudenInfoConsultationRequests(int studentId);

        Task<ConsultationRequest?> GetFacultyaInfoConsultationRequests(int facultyId);

        Task<List<ConsultationRequest>> GetConsultationRequestInfo(string programName);

        Task<Student> GetStudentInformation(string studentUMNumber);
    }
}
