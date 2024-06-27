namespace AgriSage.API.Shops.Domain.Model.ValueObjects;

public record ProductList(string Product)
{
    public ProductList() : this(string.Empty)
    {
        
    }
}