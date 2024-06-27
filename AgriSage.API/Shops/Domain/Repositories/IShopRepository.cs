using AgriSage.API.Shared.Domain.Repositories;
using AgriSage.API.Shops.Domain.Model.Aggregates;

namespace AgriSage.API.Shops.Domain.Repositories;

public interface IShopRepository : IBaseRepository<Shop>
{
    Task<Shop?> FindShopByIdAsync(int id);
}