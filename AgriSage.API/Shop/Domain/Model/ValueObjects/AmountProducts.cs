namespace AgriSage.API.Shop.Domain.Model.ValueObjects;

public record AmountProducts(int Amount)
{
    public AmountProducts() : this(int.MinValue)
    {
    }
}