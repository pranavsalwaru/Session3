using BoilerplateSession3.Models;
using BoilerplateSession3.Services;
using MediatR;

namespace BoilerplateSession3.Context.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetAllStudents();
        }
    }
}
