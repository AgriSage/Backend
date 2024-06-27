using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Interfaces.REST.Resources;

namespace AgriSage.API.Shops.Interfaces.REST.Transform;

public static class ShopResourceFromEntityAssembler
{
    public static ShopResource ToResourceFromEntity(Shop entity)
    {
        return new ShopResource(entity.Id, entity.ProductList, entity.TotalPrice);
    }
}