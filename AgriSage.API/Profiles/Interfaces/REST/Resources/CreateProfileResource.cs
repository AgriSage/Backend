namespace AgriSage.API.Profiles.Interfaces.REST.Resources;

public record CreateProfileResource(string FirstName, string LastName, string Email, string Password, string Courses, string Resources)
{
}