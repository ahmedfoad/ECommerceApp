using EPayment.Core.Entities;
using EPayment.Infrastrucure.Config;
using Microsoft.EntityFrameworkCore;

namespace EPayment.Infrastrucure.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    // public DbSet<EPayment.Core.Entities.ProductBrand> ProductBrands => Set<EPayment.Core.Entities.ProductBrand>();
    // public DbSet<EPayment.Core.Entities.ProductType> ProductTypes => Set<EPayment.Core.Entities.ProductType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().ToTable("Products");

        var assembly = typeof(ProductConfiguration).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);

    }
}