using BoilerplateSession3.Models;
using MediatR;

namespace BoilerplateSession3.Context
{
    public class GetStudentListByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }
    }
}
