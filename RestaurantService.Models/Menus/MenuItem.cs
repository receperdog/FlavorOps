using RestaurantService.Models.Common;
using RestaurantService.Models.Restaurants;

namespace RestaurantService.Models.Menus;

public class MenuItem : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }
    public bool IsAvailable { get; set; }
    
    //For Menu Relation
    public Guid MenuId { get; set; }
    public Menu Menu { get; set; }
    
    // For Category Relation
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}