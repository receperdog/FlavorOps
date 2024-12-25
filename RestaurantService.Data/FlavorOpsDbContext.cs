using Microsoft.EntityFrameworkCore;
using RestaurantService.Models.Common;
using RestaurantService.Models.Menus;
using RestaurantService.Models.Restaurants;

namespace RestaurantService.Data;

public class FlavorOpsDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Category> Categories { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is BaseEntity 
                        && (e.State == EntityState.Added || e.State == EntityState.Modified));
        foreach (var entityEntry in entries)
        {
            if (entityEntry.Entity is not BaseEntity baseEntity) continue;
            if (entityEntry.State == EntityState.Added)
            {
                baseEntity.CreatedAt = DateTime.UtcNow;
                baseEntity.IsDeleted = false;
            }
            baseEntity.UpdatedAt = DateTime.UtcNow;
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is BaseEntity 
                        && (e.State == EntityState.Added || e.State == EntityState.Modified));
        foreach (var entityEntry in entries)
        {
            if (entityEntry.Entity is not BaseEntity baseEntity) continue;
            if (entityEntry.State == EntityState.Added)
            {
                baseEntity.CreatedAt = DateTime.UtcNow;
                baseEntity.IsDeleted = false;
            }
            baseEntity.UpdatedAt = DateTime.UtcNow;
        }
        return base.SaveChanges();
    }
}