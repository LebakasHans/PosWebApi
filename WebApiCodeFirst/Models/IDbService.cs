using SchoolWebApi.Dtos;

namespace WebApiCodeFirst.Models;

public interface IDbService
{
  public IEnumerable<CourseDto> AllCourses();
  public CourseDto GetCourse(int id);
  public IEnumerable<ClassDto> AllClassesByCourse(int id);
  public IEnumerable<InstructorDto> AllInstructors();
  public IEnumerable<SectionDto> AllSections();
  public IEnumerable<ClassDto> AllClassesBySection(int id);
  public IEnumerable<StudentDto> AllStudentsByName(string nameQuery);
  public IEnumerable<StudentDto> AllStudentsByAddress(string addressQuery);
}
