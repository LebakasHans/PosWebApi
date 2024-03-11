using Microsoft.AspNetCore.Mvc;

using SchoolWebApi.Dtos;
using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("Sections")]
[ApiController]
public class SectionsController(IDbService service) : ControllerBase
{
  [HttpGet]
  public IEnumerable<SectionDto> GetAllSections()
  {
    return service.AllSections();
  }

  [HttpGet("{id}/Classes")]
  public IEnumerable<ClassDto> GetClassesBySection(int id)
  {
    return service.AllClassesBySection(id);
  }
}
