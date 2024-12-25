using RestaurantService.Models.Common;
using RestaurantService.Models.Menus;

namespace RestaurantService.Models.Restaurants;

public class Menu : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    // For Restaurant relation
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    // For MenuItem relation
    public ICollection<MenuItem> MenuItems { get; set; }
}