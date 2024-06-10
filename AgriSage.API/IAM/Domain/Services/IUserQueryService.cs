using AgriSage.API.IAM.Domain.Model.Aggregates;
using AgriSage.API.IAM.Domain.Model.Commands;
using AgriSage.API.IAM.Domain.Model.Queries;

namespace AgriSage.API.IAM.Domain.Services;

public interface IUserQueryService
{
    Task<User?> Handle(GetUserByIdQuery query);
    Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
    Task<User?> Handle(GetUserByUsernameQuery query);
}