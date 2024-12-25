using RestaurantService.Models.Common;

namespace RestaurantService.Models.Restaurants;

public class Restaurant : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string OpeningHours { get; set; }
    public bool IsActive { get; set; }
    // For Menu Relation
    public ICollection<Menu> Menus { get; set; }
    
}