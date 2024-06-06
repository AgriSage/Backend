using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
        builder.AddCreatedUpdatedInterceptor();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
    }
}