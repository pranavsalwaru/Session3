using BoilerplateSession3.Models;
using BoilerplateSession3.Services;
using MediatR;

namespace BoilerplateSession3.Context.Handlers
{
    public class GetAllStudentHandler : IRequestHandler<GetStudentListByIdQuery, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public GetAllStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> Handle(GetStudentListByIdQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentById(request.Id);
        }
    }
}
