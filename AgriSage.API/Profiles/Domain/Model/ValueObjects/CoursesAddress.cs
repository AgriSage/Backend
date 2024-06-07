namespace AgriSage.API.Profiles.Domain.Model.ValueObjects;

public record CoursesAddress(string Courses, string Resources)
{
    public CoursesAddress() : this(string.Empty, string.Empty)
    {
    }

    public CoursesAddress(string courses) : this(courses, string.Empty)
    {
    }

    public string FullAddress => $"{Courses}, {Resources}";
}