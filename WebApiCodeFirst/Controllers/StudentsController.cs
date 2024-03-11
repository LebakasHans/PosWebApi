using Microsoft.AspNetCore.Mvc;
using SchoolWebApi.Dtos;
using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;


[ApiController]
public class StudentsController(IDbService service) : ControllerBase
{
    [HttpGet("Students")]
    public IEnumerable<StudentDto> GetAllStudentsByName(string name)
    {
        return service.AllStudentsByName(name);
    }


    [HttpGet("StudentsByAddress")]
    public IEnumerable<StudentDto> GetAllStudentsByAddress(string address)
    {
        return service.AllStudentsByAddress(address);
    }
}
