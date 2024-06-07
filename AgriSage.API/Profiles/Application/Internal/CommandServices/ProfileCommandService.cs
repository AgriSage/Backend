using AgriSage.API.Profiles.Domain.Model.Aggregates;
using AgriSage.API.Profiles.Domain.Model.Commands;
using AgriSage.API.Profiles.Domain.Repositories;
using AgriSage.API.Profiles.Domain.Services;
using AgriSage.API.Shared.Domain.Repositories;

namespace AgriSage.API.Profiles.Application.Internal.CommandServices;

public class ProfileCommandService(IProfileRepository profileRepository, IUnitOfWork unitOfWork) : IProfileCommandService
{
    public async Task<Profile?> Handle(CreateProfileCommand command)
    {
        var profile = new Profile(command);
        try
        {
            await profileRepository.AddAsync(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the profile: {e.Message}");
            return null;
        }
    }
}