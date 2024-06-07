using AgriSage.API.Profiles.Domain.Model.Commands;
using AgriSage.API.Profiles.Interfaces.REST.Resources;

namespace AgriSage.API.Profiles.Interfaces.REST.Transform;

public static class CreateProfileCommandFromResourceAssembler
{
    public static CreateProfileCommand ToCommandFromResource(CreateProfileResource resource)
    {
        return new CreateProfileCommand(resource.FirstName, resource.LastName, resource.Email, resource.Password,
            resource.Courses, resource.Resources);
    }
}