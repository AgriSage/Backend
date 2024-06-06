using AgriSage.API.IAM.Domain.Model.Aggregates;
using AgriSage.API.IAM.Domain.Repositories;
using AgriSage.API.IAM.Shared.Infrastructure.Persistence.EFC.Configuration;
using AgriSage.API.IAM.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.IAM.Infrastructure.Persistence.EFC.Repositories;

public class UserRepository(AppDbContext context) : BaseRepository<User>(context), IUserRepository
{
    /**
     * <summary>
     *     Find a user by username
     * </summary>
     * <param name="username">The username to search</param>
     * <returns>The user</returns>
     */
    public async Task<User?> FindByUsernameAsync(string username)
    {
        return await Context.Set<User>().FirstOrDefaultAsync(user => user.Username.Equals(username));
    }

    /**
     * <summary>
     *     Check if a user exists by username
     * </summary>
     * <param name="username">The username to search</param>
     * <returns>True if the user exists, false otherwise</returns>
     */
    public bool ExistsByUsername(string username)
    {
        return Context.Set<User>().Any(user => user.Username.Equals(username));
    }
}