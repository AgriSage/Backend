namespace AgriSage.API.Profiles.Interfaces.ACL;

public interface IProfilesContextFacade
{
    Task<int> CreateProfile(string firstName, string lastName, string email, string password, string courses, string resources);

    Task<int> FetchProfileIdByEmail(string email);
}