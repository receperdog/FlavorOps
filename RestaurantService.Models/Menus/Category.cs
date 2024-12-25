using RestaurantService.Models.Common;

namespace RestaurantService.Models.Menus;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    // For MenuItem Relation
    public ICollection<MenuItem> MenuItems { get; set; }
    
}