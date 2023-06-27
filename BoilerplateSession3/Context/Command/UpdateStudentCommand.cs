using BoilerplateSession3.Models;
using MediatR;
using System.Net;
using System.Xml.Linq;

namespace BoilerplateSession3.Context.Command
{
    public class UpdateStudentCommand : IRequest<int>
    {
        public UpdateStudentCommand(int id, string name, string address, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
