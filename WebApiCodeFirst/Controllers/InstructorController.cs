using Microsoft.AspNetCore.Mvc;

using SchoolDbLib;

using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("instructor")]
[ApiController]
public class InstructorController(IDbService service) : ControllerBase
{
  [HttpGet]
  public IEnumerable<Instructor> GetAllInstructors()
  {
    return service.AllInstructors();
  }
}
