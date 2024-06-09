namespace AgriSage.API.Shop.Domain.Model.ValueObjects;

public record BuyList(String Products)
{
    public BuyList() : this(string.Empty)
    {
    }
}