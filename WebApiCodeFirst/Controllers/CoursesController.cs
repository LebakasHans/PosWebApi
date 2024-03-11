using Microsoft.AspNetCore.Mvc;

using SchoolDbLib;

using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("course")]
[ApiController]
public class CoursesController(IDbService service) : ControllerBase
{
  [HttpGet]
  public IEnumerable<Course> GetAllCourses()
  {
    return service.AllCourses();
  }

  [HttpGet("{id}")]
  public Course GetCourse(int id)
  {
    return service.GetCourse(id);
  }

  [HttpGet("{id}/classes")]
  public IEnumerable<Class> GetClassesByCourse(int id)
  {
    return service.AllClassesByCourse(id);
  }
}
