using AgriSage.API.IAM.Domain.Model.Aggregates;
using AgriSage.API.IAM.Domain.Model.Commands;

namespace AgriSage.API.IAM.Domain.Services;

public interface IUserCommandService
{
    Task<(User user, string token)> Handle(SignInCommand command);
    
    Task Handle(SignUpCommand command);
}