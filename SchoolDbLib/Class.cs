namespace SchoolDbLib;

public class Class
{
  public int Id { get; set; }
  public int SectionNumber { get; set; }
  public int NumRegistered { get; set; }
    public string Name { get; set; } = "There is no class name";
  public DateTime ClassDateTime { get; set; }
  public Section Section { get; set; } = null!;
  public Course Course { get; set; } = null!;
}
