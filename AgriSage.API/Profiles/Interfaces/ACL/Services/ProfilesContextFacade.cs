using AgriSage.API.Profiles.Domain.Model.Commands;
using AgriSage.API.Profiles.Domain.Model.Queries;
using AgriSage.API.Profiles.Domain.Model.ValueObjects;
using AgriSage.API.Profiles.Domain.Services;
using AgriSage.API.Profiles.Interfaces.ACL;

namespace AgriSage.API.Profiles.Interfaces.ACL.Services
{
    public class ProfilesContextFacade : IProfilesContextFacade
    {
        private readonly IProfileCommandService _profileCommandService;
        private readonly IProfileQueryService _profileQueryService;

        public ProfilesContextFacade(IProfileCommandService profileCommandService, IProfileQueryService profileQueryService)
        {
            _profileCommandService = profileCommandService;
            _profileQueryService = profileQueryService;
        }

        public async Task<int> CreateProfile(string firstName, string lastName, string email, string password, string courses, string resources)
        {
            var createProfileCommand = new CreateProfileCommand(firstName, lastName, email, password, courses, resources);
            var profile = await _profileCommandService.Handle(createProfileCommand);
            return profile?.Id ?? 0;
        }
        
        public async Task<int> FetchProfileIdByEmail(string email)
        {
            var getProfileByEmailQuery = new GetProfileByEmailQuery(new EmailAddress());
            var profile = await _profileQueryService.Handle(getProfileByEmailQuery);
            return profile?.Id ?? 0;
        }
    }
}