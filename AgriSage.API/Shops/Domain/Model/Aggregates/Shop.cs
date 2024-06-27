using AgriSage.API.Shops.Domain.Model.Commands;
using AgriSage.API.Shops.Domain.Model.ValueObjects;

namespace AgriSage.API.Shops.Domain.Model.Aggregates;

public partial class Shop
{
    public Shop()
    {
        List = new ProductList();
        Total = new TotalPrice();
    }

    public Shop(float price, string products)
    {
        List = new ProductList(products);
        Total = new TotalPrice(price);
    }

    public Shop(CreateShopCommand command)
    {
        List = new ProductList(command.Products);
        Total = new TotalPrice(command.Price);
    }
    
    public int Id { get; }
    public ProductList List { get; private set; }
    public TotalPrice Total { get; private set; }

    public string ProductList => List.Product;
    public string TotalPrice => Total.Price.ToString("$");
}