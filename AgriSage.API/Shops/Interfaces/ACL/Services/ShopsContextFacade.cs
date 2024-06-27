using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Model.Commands;
using AgriSage.API.Shops.Domain.Model.Queries;
using AgriSage.API.Shops.Domain.Services;

namespace AgriSage.API.Shops.Interfaces.ACL.Services;

public class ShopsContextFacade(IShopCommandService shopCommandService, IShopQueryService shopQueryService) : IShopsContextFacade
{
    public async Task<int> CreateShop(float price, string products)
    {
        var createShopCommand = new CreateShopCommand(price, products);
        var shop = await shopCommandService.Handle(createShopCommand);
        return shop?.Id ?? 0;
    }

    public async Task<Shop?> GetShopById(int shopId)
    {
        var getShopByIdQuery = new GetShopByIdQuery(shopId);
        return await shopQueryService.Handle(getShopByIdQuery);
    }
}