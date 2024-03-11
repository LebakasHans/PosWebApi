using Microsoft.AspNetCore.Mvc;

using SchoolDbLib;

using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;


[ApiController]
public class StudentsController(IDbService service) : ControllerBase
{
  [HttpGet("Students")]
  public IEnumerable<Student> GetAllStudentsByName(string name)
  {
    return service.AllStudentsByName(name);
  }

  
  [HttpGet("StudentsByAddress")]
  public IEnumerable<Student> GetAllStudentsByAddress(string address)
  {
    return service.AllStudentsByAddress(address);
  }
}
