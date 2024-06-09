using AgriSage.API.Shop.Domain.Model.Aggregates;
using AgriSage.API.Shop.Domain.Model.ValueObjects;
using AgriSage.API.Shared.Domain.Repositories;

namespace AgriSage.API.Shop.Domain.Repositories;

public interface IShopRepository : IBaseRepository<Model.Aggregates.Shop>
{
    Task<Model.Aggregates.Shop?> FindByIdAsync(int id);
}