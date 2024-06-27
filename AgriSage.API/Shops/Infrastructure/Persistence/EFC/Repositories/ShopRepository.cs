using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using AgriSage.API.Shops.Domain.Model.Aggregates;
using AgriSage.API.Shops.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.Shops.Infrastructure.Persistence.EFC.Repositories;

public class ShopRepository(AppDbContext context) : BaseRepository<Shop>(context), IShopRepository
{
    public Task<Shop?> FindShopByIdAsync(int id)
    {
        return Context.Set<Shop>().FirstOrDefaultAsync(p => p.Id == id);
    }
}