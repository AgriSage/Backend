using AgriSage.API.Shop.Domain.Model.Commands;
using AgriSage.API.Shop.Domain.Model.Queries;
using AgriSage.API.Shop.Domain.Services;

namespace AgriSage.API.Shop.Interfaces.ACL.Services;

public class ShopContextFacade : IShopContextFacade
{
    private readonly IShopCommandService _shopCommandService;
    private readonly IShopQueryService _shopQueryService;
    
    public ShopContextFacade(IShopCommandService shopCommandService, IShopQueryService shopQueryService)
    {
        _shopCommandService = shopCommandService;
        _shopQueryService = shopQueryService;
    }
    
    public async Task<int> CreateShop(int amount, float price, string products)
    {
        var createShopCommand = new CreateShopCommand(amount, price, products);
        var shop = await _shopCommandService.Handle(createShopCommand);
        return shop?.Id ?? 0;
    }

    public async Task<Domain.Model.Aggregates.Shop?> GetShopById(int shopId)
    {
        var getShopByIdQuery = new GetShopByIdQuery(shopId);
        return await _shopQueryService.Handle(getShopByIdQuery);
    }
}