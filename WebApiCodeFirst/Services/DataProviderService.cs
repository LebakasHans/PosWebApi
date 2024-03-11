using SchoolDbLib;
using SchoolWebApi.Dtos;
using WebApiCodeFirst.Models;

namespace WebApiCodeFirst.Services;

public class DataProviderService(SchoolContext db) : IDbService
{
  public IEnumerable<CourseDto> AllCourses()
  {
        return db.Courses.Select(c => new CourseDto
        {
            CourseNumber = c.Id,
            CourseName = c.Name,
            InstructorName = c.Instructor.Name,
            NrClasses = c.Classes.Count(),
            NrStudents = db.StudentCourses.Count(x => x.Id == c.Id)
        }).ToList();
  }

  public CourseDto GetCourse(int id)
  {
        return db.Courses.Select(c => new CourseDto
        {
            CourseNumber = c.Id,
            CourseName = c.Name,
            InstructorName = c.Instructor.Name,
            NrClasses = c.Classes.Count(),
            NrStudents = db.StudentCourses.Count(x => x.Id == c.Id)
        }).First(x => x.CourseNumber == id);
    }

  public IEnumerable<ClassDto> AllClassesByCourse(int id)
  {
    return db.Classes.Where(c => c.Course.Id == id).Select(c => new ClassDto
    {
        Id = c.Id,
        Name = c.Name,
        CourseName = c.Course.Name,
        ClassDateTime = c.ClassDateTime
    }).ToList();
  }

  public IEnumerable<InstructorDto> AllInstructors()
  {
    return db.Instructors.Select(i => new InstructorDto
    {
        Id = i.Id,
        Name = i.Name
    }).ToList();
  }

  public IEnumerable<SectionDto> AllSections()
  {
    return db.Sections.Select(s => new SectionDto
    {
        Id = s.SectionNumber,
        ProfessorName = s.Professor.Name
    }).ToList();
  }

  public IEnumerable<ClassDto> AllClassesBySection(int id)
  {
    return db.Classes.Where(c => c.Section.SectionNumber == id).Select(c => new ClassDto
    {
        Id = c.Id,
        Name = c.Name,
        CourseName = c.Course.Name,
        ClassDateTime = c.ClassDateTime
    }).ToList();
  }

  public IEnumerable<StudentDto> AllStudentsByName(string nameQuery)
  {
    return db.Students.Where(s => s.Name.Contains(nameQuery)).Select(s => new StudentDto
    {
        Id = s.Id,
        Name = s.Name,
        Address = s.Address
    }).ToList();
  }

  public IEnumerable<StudentDto> AllStudentsByAddress(string addressQuery)
  {
    return db.Students.Where(s => s.Address.Contains(addressQuery)).Select(s => new StudentDto
    {
        Id = s.Id,
        Name = s.Name,
        Address = s.Address
    }).ToList();
  }
}
