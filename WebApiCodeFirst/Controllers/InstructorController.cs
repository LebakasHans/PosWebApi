using Microsoft.AspNetCore.Mvc;
using SchoolWebApi.Dtos;
using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("Instructors")]
[ApiController]
public class InstructorController(IDbService service) : ControllerBase
{
    [HttpGet]
    public IEnumerable<InstructorDto> GetAllInstructors()
    {
        return service.AllInstructors();
    }
}
