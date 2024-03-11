namespace SchoolWebApi.Dtos;

public class CourseDto
{
    public int CourseNumber { get; set; }
    public string CourseName { get; set; } = null!;
    public string InstructorName { get; set; } = null!;
    public int NrClasses { get; set; }
    public int NrStudents { get; set; }
}
