namespace AgriSage.API.Profiles.Domain.Model.ValueObjects
{
    public record EmailAddress(string Address, string Password)
    {
        public EmailAddress() : this(string.Empty, string.Empty)
        {
        }
    }
}