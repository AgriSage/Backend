using AgriSage.API.Shop.Domain.Model.Commands;
using AgriSage.API.Shop.Interfaces.REST.Resources;

namespace AgriSage.API.Shop.Interfaces.REST.Transform;

public static class CreateShopCommandFromResourceAssembler
{
    public static CreateShopCommand ToCommandFromResource(CreateShopResource resource)
    {
        return new CreateShopCommand(resource.Amount, resource.Price, resource.Products);
    }
}
