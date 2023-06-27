using BoilerplateSession3.Context.Command;
using BoilerplateSession3.Services;
using MediatR;

namespace BoilerplateSession3.Context.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentById(request.Id);
            if (student == null) 
            {
                return default; 
            }

            student.Name = request.Name;
            student.Address = request.Address;
            student.Email = request.Email;

            return await _studentRepository.UpdateStudent(student);
        }
    }
}
