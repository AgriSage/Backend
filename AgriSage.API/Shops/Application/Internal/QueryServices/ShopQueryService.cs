using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Model.Queries;
using AgriSage.API.Shops.Domain.Repositories;
using AgriSage.API.Shops.Domain.Services;

namespace AgriSage.API.Shops.Application.Internal.QueryServices;

public class ShopQueryService(IShopRepository shopRepository) : IShopQueryService
{
    public async Task<IEnumerable<Shop>> Handle(GetAllShopsQuery query)
    {
        return await shopRepository.ListAsync();
    }

    public async Task<Shop?> Handle(GetShopByIdQuery query)
    {
        return await shopRepository.FindByIdAsync(query.ShopId);
    }
}