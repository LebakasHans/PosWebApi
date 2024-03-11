using System.ComponentModel.DataAnnotations;

namespace SchoolDbLib;

public class Section
{
  [Key] public int SectionNumber { get; set; }
  public Professor Professor { get; set; }
}
