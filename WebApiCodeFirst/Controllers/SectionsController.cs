using Microsoft.AspNetCore.Mvc;

using SchoolDbLib;

using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Controllers;

[Route("sections")]
[ApiController]
public class SectionsController(IDbService service) : ControllerBase
{
  [HttpGet]
  public IEnumerable<Section> GetAllSections()
  {
    return service.AllSections();
  }

  [HttpGet("{id}/classes")]
  public IEnumerable<Class> GetClassesBySection(int id)
  {
    return service.AllClassesBySection(id);
  }
}
