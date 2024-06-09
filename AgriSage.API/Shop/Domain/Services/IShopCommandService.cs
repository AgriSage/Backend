using AgriSage.API.Shop.Domain.Model.Commands;

namespace AgriSage.API.Shop.Domain.Services;

public interface IShopCommandService
{
    Task<Model.Aggregates.Shop?> Handle(CreateShopCommand command);
}