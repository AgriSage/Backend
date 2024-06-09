using AgriSage.API.Shop.Domain.Model.Queries;

namespace AgriSage.API.Shop.Domain.Services;

public interface IShopQueryService
{
    Task<IEnumerable<Model.Aggregates.Shop>> Handle(GetAllShopQuery query);
    Task<Model.Aggregates.Shop?> Handle(GetShopByIdQuery query);
}