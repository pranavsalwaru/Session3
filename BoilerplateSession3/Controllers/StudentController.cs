using BoilerplateSession3.Context;
using BoilerplateSession3.Context.Command;
using BoilerplateSession3.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateSession3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Student>> StudentList()
        {
            var studentList = await _mediator.Send(new GetStudentListQuery());
            return studentList;
        }

        [HttpGet("{id}")]
        public async Task<Student> StudentById(int id)
        {
            var studentData = await _mediator.Send(new GetStudentListByIdQuery() { Id = id });
            return studentData;
        }

        [HttpPost]
        public async Task<Student> AddStudent(Student student)
        {
            var studentData = await _mediator.Send(new CreateStudentCommand(
                student.Name, student.Address, student.Email
                ));
            return studentData;
        }

        [HttpPut]
        public async Task<int> UpdateStudent(Student student)
        {
            var studentData = await _mediator.Send(new UpdateStudentCommand(
                student.Id, student.Name, student.Address, student.Email));
            return studentData;
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        { 
            return await _mediator.Send(new DeleteStudentCommand() { Id = id });
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
