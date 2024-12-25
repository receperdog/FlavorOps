using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Restaurants;

namespace RestaurantService.Data.Repositories.Implementations;

public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
{
    public RestaurantRepository( FlavorOpsDbContext flavorOpsDbContext ) : base(flavorOpsDbContext)
    {
    }
}