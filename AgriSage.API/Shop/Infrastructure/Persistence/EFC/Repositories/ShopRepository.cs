using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using AgriSage.API.Shop.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.Shop.Infrastructure.Persistence.EFC.Repositories;

public class ShopRepository(AppDbContext context) : BaseRepository<Domain.Model.Aggregates.Shop>(context), IShopRepository
{
    public Task<Domain.Model.Aggregates.Shop?> FindShopByIdAsync(int id)
        {
            return Context.Set<Domain.Model.Aggregates.Shop>().FirstOrDefaultAsync(p => p.Id == id);
        }
    public async Task<IEnumerable<Domain.Model.Aggregates.Shop>> ListAsync()
    {
        return await Context.Set<Domain.Model.Aggregates.Shop>().ToListAsync();
    }
}

   
    
