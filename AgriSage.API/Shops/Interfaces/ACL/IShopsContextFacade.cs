using AgriSage.API.Shops.Domain.Model.Aggregates;

namespace AgriSage.API.Shops.Interfaces.ACL;

public interface IShopsContextFacade
{
    Task<int> CreateShop(float price, string products);
    Task<Shop?> GetShopById(int shopId);
}