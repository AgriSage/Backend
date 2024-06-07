using AgriSage.API.Domain.Model.ValueObjects;
using AgriSage.API.Profiles.Domain.Model.Commands;
using AgriSage.API.Profiles.Domain.Model.ValueObjects;

namespace AgriSage.API.Profiles.Domain.Model.Aggregates;


public partial class Profile
{
    public Profile()
    {
        Name = new PersonName();
        Email = new EmailAddress();
        Address = new CoursesAddress();
    }

    public Profile(string firstName, string lastName, string email, string password, string courses, string resources,
        string postalCode, string country)
    {
        Name = new PersonName(firstName, lastName);
        Email = new EmailAddress(email,password);
        Address = new CoursesAddress(courses,resources);
    }

    public Profile(CreateProfileCommand command)
    {
        Name = new PersonName(command.FirstName, command.LastName);
        Email = new EmailAddress(command.Email,command.Password);
        Address = new CoursesAddress(command.Courses, command.Resources);
    }

    public int Id { get; }
    public PersonName Name { get; private set; }
    public EmailAddress Email { get; private set; }
    public CoursesAddress Address { get; private set; }

    public string FullName => Name.FullName;

    public string EmailAddress => Email.Address;

    public string CoursesAddress => Address.FullAddress;
}