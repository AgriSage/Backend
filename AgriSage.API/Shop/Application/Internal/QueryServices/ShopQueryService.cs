using AgriSage.API.Shop.Domain.Model.Queries;
using AgriSage.API.Shop.Domain.Repositories;
using AgriSage.API.Shop.Domain.Services;

namespace AgriSage.API.Shop.Application.Internal.QueryServices;

public class ShopQueryService(IShopRepository shopRepository) : IShopQueryService
{
    public async Task<IEnumerable<Domain.Model.Aggregates.Shop>> Handle(GetAllShopQuery query)
    {
        return await shopRepository.ListAsync();
    }

    public async Task<Domain.Model.Aggregates.Shop?> Handle(GetShopByIdQuery query)
    {
        return await shopRepository.FindByIdAsync(query.ShopId);
    }
}