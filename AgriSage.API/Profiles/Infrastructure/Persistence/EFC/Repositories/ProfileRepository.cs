using AgriSage.API.Profiles.Domain.Model.Aggregates;
using AgriSage.API.Profiles.Domain.Model.ValueObjects;
using AgriSage.API.Profiles.Domain.Repositories;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.Profiles.Infrastructure.Persistence.EFC.Repositories;

public class ProfileRepository(AppDbContext context) : BaseRepository<Profile>(context), IProfileRepository
{
    public Task<Profile?> FindProfileByEmailAsync(EmailAddress email)
    {
        return Context.Set<Profile>().Where(p => p.Email == email).FirstOrDefaultAsync();
    }
}