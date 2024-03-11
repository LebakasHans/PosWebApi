using SchoolDbLib;

using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Services;

public class DataProviderService : IDbService
{
  public IEnumerable<Course> AllCourses()
  {
    throw new NotImplementedException();
  }

  public Course GetCourse(int id)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Class> AllClassesByCourse(int id)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Instructor> AllInstructors()
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Section> AllSections()
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Class> AllClassesBySection(int id)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Student> AllStudentsByName(string nameQuery)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Student> AllStudentsByAddress(string addressQuery)
  {
    throw new NotImplementedException();
  }
}
