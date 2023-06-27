using BoilerplateSession3.Context.Command;
using BoilerplateSession3.Services;
using MediatR;

namespace BoilerplateSession3.Context.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
             _studentRepository = studentRepository;    
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentById(request.Id);
            if (student == null) 
            {
                return default; 
            }

            return await _studentRepository.DeleteStudent(request.Id);
        }
    }
}
