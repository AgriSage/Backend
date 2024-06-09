namespace AgriSage.API.Payments.Domain.Model.ValueObjects;

public record ExpiryDate(DateTime Value)
{
    public ExpiryDate() : this(DateTime.MinValue)
    {
        
    }
}