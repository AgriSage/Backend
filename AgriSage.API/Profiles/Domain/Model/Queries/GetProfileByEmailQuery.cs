using AgriSage.API.Profiles.Domain.Model.ValueObjects;

namespace AgriSage.API.Profiles.Domain.Model.Queries;

public record GetProfileByEmailQuery(EmailAddress Email);