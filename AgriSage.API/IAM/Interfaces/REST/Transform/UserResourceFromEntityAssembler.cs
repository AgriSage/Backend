using AgriSage.API.IAM.Domain.Model.Aggregates;
using AgriSage.API.IAM.Interfaces.REST.Resources;

namespace AgriSage.API.IAM.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.Id, user.Username);
    }
}