using SchoolDbLib;

namespace WebApiCodeFirst.Models;

public interface IDbService
{
  public IEnumerable<Course> AllCourses();
  public Course GetCourse(int id);
  public IEnumerable<Class> AllClassesByCourse(int id);
  public IEnumerable<Instructor> AllInstructors();
  public IEnumerable<Section> AllSections();
  public IEnumerable<Class> AllClassesBySection(int id);
  public IEnumerable<Student> AllStudentsByName(string nameQuery);
  public IEnumerable<Student> AllStudentsByAddress(string addressQuery);
}
