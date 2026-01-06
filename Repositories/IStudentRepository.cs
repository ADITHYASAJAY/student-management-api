using StudentManagement.API.Models;

namespace StudentManagement.API.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Task AddSync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Student student);
    }
}
