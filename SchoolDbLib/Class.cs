namespace SchoolDbLib;

public class Class
{
  public int Id { get; set; }
  public int SectionNumber { get; set; }
  public int NumRegistered { get; set; }
  public DateTime ClassDateTime { get; set; }
  public Section Section { get; set; } = null!;
  public Course Course { get; set; } = null!;
}
