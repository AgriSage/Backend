using AgriSage.API.Shared.Domain.Repositories;
using AgriSage.API.Shop.Domain.Model.Commands;
using AgriSage.API.Shop.Domain.Repositories;
using AgriSage.API.Shop.Domain.Services;

namespace AgriSage.API.Shop.Application.Internal.CommandServices;

public class ShopCommandService(IShopRepository shopRepository, IUnitOfWork unitOfWork) : IShopCommandService
{
    public async Task<Domain.Model.Aggregates.Shop?> Handle(CreateShopCommand command)
    {
        var shop = new Domain.Model.Aggregates.Shop(command);
        try
        {
            await shopRepository.AddAsync(shop);
            await unitOfWork.CompleteAsync();
            return shop;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            return null;
        }
    }
}