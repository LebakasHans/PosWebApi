using Microsoft.EntityFrameworkCore;

namespace SchoolDbLib;

public partial class SchoolContext : DbContext
{
    public SchoolContext() { }
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    public DbSet<Class> Classes { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<LogEntry> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;
        string connectionString = @"Server=(LocalDB)\mssqllocaldb;attachdbfilename=C:\tmp\School.mdf;database=School;integrated security=True;MultipleActiveResultSets=True";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
