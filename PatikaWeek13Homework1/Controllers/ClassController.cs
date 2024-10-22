using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaWeek13Homework1.Conrete;

namespace PatikaWeek13Homework1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClass()
        {
            Teacher teacher = new Teacher()
            {
                FirstName= "Sertan",
                LastName="Bozkuş"
            };

            ClassRoom classRoom = new ClassRoom(teacher);

            return Ok(classRoom.GetTeacherInfo());
        }
    }
}
