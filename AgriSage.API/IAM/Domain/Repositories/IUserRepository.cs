using AgriSage.API.IAM.Domain.Model.Aggregates;
using AgriSage.API.Shared.Domain.Repositories;

namespace AgriSage.API.IAM.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{

    Task<User?> FindByUsernameAsync(string username);
    
    bool ExistsByUsername(string username);
}