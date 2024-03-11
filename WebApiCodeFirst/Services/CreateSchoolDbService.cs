
using SchoolDbLib;

namespace WebApiCodeFirst.Services;

public class CreateSchoolDbService(IServiceProvider serviceProvider) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<SchoolContext>();
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
        AssertDbSeeded(db);

        return Task.CompletedTask;
    }

    private void AssertDbSeeded(SchoolContext db)
    {
        //create a bunch of test data for professor
        var professors = new List<Professor>
        {
            new Professor { Name = "Prof. John Doe", Faculty = "Science" },
            new Professor { Name = "Prof. Jane Doe", Faculty = "Science" },
            new Professor { Name = "Prof. Jim Doe", Faculty = "Science" }
        };

        db.Professors.AddRange(professors);
        db.SaveChanges();

        var sections = new List<Section>
        {
            new Section { Professor = professors[0] },
            new Section { Professor = professors[1] },
            new Section { Professor = professors[2] }
        };

        db.Sections.AddRange(sections);
        db.SaveChanges();

        var students = new List<Student>
        {
            new Student { Name = "Alice", Address = "123 Elm" },
            new Student { Name = "Bob", Address = "456 Oak" },
            new Student { Name = "Charlie", Address = "789 Pine" }
        };

        db.Students.AddRange(students);
        db.SaveChanges();

        var instructors = new List<Instructor>
        {
            new Instructor { Name = "John Doe Instructor", Faculty = "Science" },
            new Instructor { Name = "Jane Doe Instructor", Faculty = "Science" },
            new Instructor { Name = "Jim Doe Instructor", Faculty = "Science" }
        };

        db.Instructors.AddRange(instructors);
        db.SaveChanges();

        var courses = new List<Course>
        {
            new Course { Name = "Math", Instructor = instructors[0] },
            new Course { Name = "Science", Instructor = instructors[1] },
            new Course { Name = "History", Instructor = instructors[2] }
        };

        db.Courses.AddRange(courses);
        db.SaveChanges();

        var classes = new List<Class>
        {
            new Class { Name = "Math 101", Course = courses[0], ClassDateTime = DateTime.Now, Section = sections[0] },
            new Class { Name = "Science 101", Course = courses[1], ClassDateTime = DateTime.Now, Section = sections[1] },
            new Class { Name = "History 101", Course = courses[2], ClassDateTime = DateTime.Now, Section = sections[2] }
        };

        db.Classes.AddRange(classes);
        db.SaveChanges();

    }
}
