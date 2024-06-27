using AgriSage.API.Shared.Domain.Repositories;
using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Model.Commands;
using AgriSage.API.Shops.Domain.Repositories;
using AgriSage.API.Shops.Domain.Services;

namespace AgriSage.API.Shops.Application.Internal.CommandServices;

public class ShopCommandService(IShopRepository shopRepository, IUnitOfWork unitOfWork) : IShopCommandService
{
    public async Task<Shop?> Handle(CreateShopCommand command)
    {
        var shop = new Shop(command);
        try
        {
            await shopRepository.AddAsync(shop);
            await unitOfWork.CompleteAsync();
            return shop;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the shop: {{e.Message}}");
            return null;
        }
    }
}

