using BoilerplateSession3.Models;
using MediatR;

namespace BoilerplateSession3.Context.Command
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public CreateStudentCommand(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
