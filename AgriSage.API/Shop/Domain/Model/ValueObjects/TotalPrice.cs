namespace AgriSage.API.Shop.Domain.Model.ValueObjects;

public record TotalPrice(float Price)
{
    public TotalPrice() : this(float.MinValue)
    {
    }
}