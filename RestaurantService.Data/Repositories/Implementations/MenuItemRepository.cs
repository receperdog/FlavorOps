using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Menus;

namespace RestaurantService.Data.Repositories.Implementations;

public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(FlavorOpsDbContext dbContext) : base(dbContext)
    {
        
    }
}