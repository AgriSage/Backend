using AgriSage.API.Shops.Domain.Model.Commands;
using AgriSage.API.Shops.Interfaces.REST.Resources;

namespace AgriSage.API.Shops.Interfaces.REST.Transform;

public static class CreateShopCommandFromResourceAssembler
{
    public static CreateShopCommand ToCommandFromResource(CreateShopResource resource)
    {
        return new CreateShopCommand(resource.Price, resource.Products);
    }
}