using BoilerplateSession3.Context.Command;
using BoilerplateSession3.Models;
using BoilerplateSession3.Services;
using MediatR;

namespace BoilerplateSession3.Context.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;   
        }

        public async Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            Student stu = new Student
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email
            };
            return await _studentRepository.AddStudent(stu);
        }
    }
}
