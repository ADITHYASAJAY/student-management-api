using StudentManagement.API.DTOs;

namespace StudentManagement.API.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetStudentAsync();
        Task<StudentDto> GetStudentByIdAsync(int id);
        Task CreateStudentAsync(CreateStudentDto dto);
    }
}
