using Microsoft.AspNetCore.Mvc;
using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Restaurants;

namespace RestaurantService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController : ControllerBase
{
    // Normally repository layer should not be used here. I used for test purpose.
    private readonly IRestaurantRepository _restaurantRepository;

    public RestaurantsController(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
    {
        await _restaurantRepository.AddAsync(restaurant);
        await _restaurantRepository.SaveAsync();
        return Ok(restaurant);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRestaurants()
    {
        var restaurants = await _restaurantRepository.GetAllAsync();
        return Ok(restaurants);
    }
}