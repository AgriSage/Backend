using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Model.Commands;

namespace AgriSage.API.Shops.Domain.Services;

public interface IShopCommandService
{
    Task<Shop?> Handle(CreateShopCommand command);
}