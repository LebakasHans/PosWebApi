namespace SchoolDbLib;

public class Course
{
  public int Id { get; set; }
  public string Name { get; set; } = null!;
  public Instructor Instructor { get; set; } = null!;
  public List<Class> Classes { get; set; } = null!;
}
