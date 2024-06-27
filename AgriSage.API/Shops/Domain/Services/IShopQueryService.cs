using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Model.Queries;

namespace AgriSage.API.Shops.Domain.Services;

public interface IShopQueryService
{
    Task<IEnumerable<Shop>> Handle(GetAllShopsQuery query);
    Task<Shop?> Handle(GetShopByIdQuery query);
}