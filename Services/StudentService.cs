using StudentManagement.API.DTOs;
using StudentManagement.API.Models;
using StudentManagement.API.Repositories;

namespace StudentManagement.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository) {
            _repository = repository;
        }
        public async Task CreateStudentAsync(CreateStudentDto dto)
        {
            var student = new Student { 
                FullName = dto.FullName,
                Email = dto.Email,
                DateOfBirth = dto.DateOfBirth,
            };

            await _repository.AddSync(student);
        }

        public async Task<IEnumerable<StudentDto>> GetStudentAsync()
        {
            var students = await _repository.GetAllAsync();
            return students.Select(student => new StudentDto
            {
                Id = student.Id,
                FullName = student.FullName,
                Email=student.Email,
                DateOfBirth = student.DateOfBirth
            });
        }

        public async Task<StudentDto> GetStudentByIdAsync(int id)
        {
            var student = await _repository.GetByIdAsync(id);

            return new StudentDto
            {
                Id = student.Id,
                FullName = student.FullName,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth

            };
        }
    }
}
