using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Menus;

namespace RestaurantService.Data.Repositories.Implementations;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(FlavorOpsDbContext dbContext) : base(dbContext)
    {
        
    }
    
}