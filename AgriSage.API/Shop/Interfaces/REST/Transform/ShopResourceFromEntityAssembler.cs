using AgriSage.API.Shop.Interfaces.REST.Resources;

namespace AgriSage.API.Shop.Interfaces.REST.Transform;

public static class ShopResourceFromEntityAssembler
{
    public static ShopResource ToResourceFromEntity(Domain.Model.Aggregates.Shop entity)
    {
        return new ShopResource(entity.Id, entity.Amount, entity.Buy, entity.Price);
    }
}
    
