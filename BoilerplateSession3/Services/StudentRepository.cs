using BoilerplateSession3.Context;
using BoilerplateSession3.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateSession3.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Student> AddStudent(Student student)
        {
            var result = _applicationDbContext.Students.Add(student);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudent(int id)
        {
            var dele = _applicationDbContext.Students.Where(x => x.Id == id).FirstOrDefault();
            _applicationDbContext.Students.Remove(dele);
            return await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var filterData = await _applicationDbContext.Students.ToListAsync();
            return filterData;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var filterData =  _applicationDbContext.Students.Where(X => X.Id == id).FirstOrDefault();
            return filterData;
        }

        public async Task<int> UpdateStudent(Student student)
        {
            _applicationDbContext.Students.Update(student);
            return await _applicationDbContext.SaveChangesAsync();
        }
    }
}
