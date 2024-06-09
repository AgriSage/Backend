using AgriSage.API.Shop.Domain.Model.Commands;
using AgriSage.API.Shop.Domain.Model.ValueObjects;

namespace AgriSage.API.Shop.Domain.Model.Aggregates;

public partial class Shop
{
    public Shop()
    {
        Amount = new AmountProducts();
        Price = new TotalPrice();
        Buy = new BuyList();
    }

    public Shop(int amount, float price, string products)
    {
        Amount = new AmountProducts(amount);
        Price = new TotalPrice(price);
        Buy = new BuyList(products);
    }

    public Shop(CreateShopCommand command)
    {
        Amount = new AmountProducts(command.Amount);
        Price = new TotalPrice(command.Price);
        Buy = new BuyList(command.Products);
    }
    
    public int Id { get; }
    public AmountProducts Amount { get; private set; }
    public TotalPrice Price { get; private set; }
    public BuyList Buy { get; private set; }
    
}