namespace AgriSage.API.Shop.Interfaces.ACL;

public interface IShopContextFacade
{
    Task<int> CreateShop(int amount, float price, string products);
    
    Task<Domain.Model.Aggregates.Shop?> GetShopById(int shopId);
}
    
    
