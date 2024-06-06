using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Payments.Domain.Model.Aggregates.Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
        // Enable Audit Fields Interceptors
        builder.AddCreatedUpdatedInterceptor();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Payments Context Configuration

        builder.Entity<Payment>().HasKey(p => p.Id);
        builder.Entity<Payment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

        builder.Entity<Payment>().OwnsOne(p => p.Cardnumber,
            cn =>
            {
                cn.WithOwner().HasForeignKey("PaymentId");
                cn.Property(p => p.Value).HasColumnName("CardNumber").IsRequired().HasMaxLength(16);
            });

        builder.Entity<Payment>().OwnsOne(p => p.Cardverification,
            cv =>
            {
                cv.WithOwner().HasForeignKey("PaymentId");
                cv.Property(p => p.Value).HasColumnName("CVV").IsRequired().HasMaxLength(3);
            });

        builder.Entity<Payment>().OwnsOne(p => p.Expirydate,
            ed =>
            {
                ed.WithOwner().HasForeignKey("PaymentId");
                ed.Property(p => p.Value).HasColumnName("ExpiryDate").IsRequired();
            });

        // Apply SnakeCase Naming Convention
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
    }
}