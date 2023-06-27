using BoilerplateSession3.Models;

namespace BoilerplateSession3.Services
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllStudents();
        public Task<Student> GetStudentById(int id);
        public Task<Student> AddStudent(Student student);
        public Task<int> DeleteStudent(int id);
        public Task<int> UpdateStudent(Student student);
    }
}
