using BoilerplateSession3.Models;
using MediatR;

namespace BoilerplateSession3.Context
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
