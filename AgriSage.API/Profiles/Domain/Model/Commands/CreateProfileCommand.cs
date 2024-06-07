namespace AgriSage.API.Profiles.Domain.Model.Commands;

public record CreateProfileCommand(string FirstName, string LastName, string Email, string Password, string Courses, string Resources);