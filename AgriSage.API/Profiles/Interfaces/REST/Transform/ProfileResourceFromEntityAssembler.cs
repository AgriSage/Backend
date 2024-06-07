using AgriSage.API.Profiles.Domain.Model.Aggregates;
using AgriSage.API.Profiles.Interfaces.REST.Resources;

namespace AgriSage.API.Profiles.Interfaces.REST.Transform;

public static class ProfileResourceFromEntityAssembler
{
    public static ProfileResource ToResourceFromEntity(Profile entity)
    {
        return new ProfileResource(entity.Id, entity.FullName, entity.EmailAddress, entity.CoursesAddress);
    }
}