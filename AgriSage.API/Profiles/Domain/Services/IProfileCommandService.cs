using AgriSage.API.Profiles.Domain.Model.Aggregates;
using AgriSage.API.Profiles.Domain.Model.Commands;

namespace AgriSage.API.Profiles.Domain.Services;

public interface IProfileCommandService
{
    Task<Profile?> Handle(CreateProfileCommand command);
}