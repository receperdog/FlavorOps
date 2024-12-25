using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Restaurants;

namespace RestaurantService.Data.Repositories.Implementations;

public class MenuRepository : Repository<Menu> , IMenuRepository 
{
    public MenuRepository(FlavorOpsDbContext dbContext) : base(dbContext)
    {
        
    }
    
}