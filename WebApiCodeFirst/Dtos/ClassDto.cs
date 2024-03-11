namespace SchoolWebApi.Dtos;

public class ClassDto
{
    public int Id { get; set; }
    public string CourseName { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime ClassDateTime { get; set; }
}
