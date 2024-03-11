using Microsoft.AspNetCore.Mvc;
using SchoolWebApi.Dtos;
using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("Courses")]
[ApiController]
public class CoursesController(IDbService service) : ControllerBase
{
    [HttpGet]
    public IEnumerable<CourseDto> GetAllCourses()
    {
        return service.AllCourses();
    }

    [HttpGet("{id}")]
    public CourseDto GetCourse(int id)
    {
        return service.GetCourse(id);
    }

    [HttpGet("{id}/Clazzes")]
    public IEnumerable<ClassDto> GetClassesByCourse(int id)
    {
        return service.AllClassesByCourse(id);
    }
}
