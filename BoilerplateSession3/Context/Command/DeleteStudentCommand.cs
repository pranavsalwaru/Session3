using MediatR;

namespace BoilerplateSession3.Context.Command
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
