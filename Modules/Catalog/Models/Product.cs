namespace Catalog.Models;

public class Product : Entity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public List<string> Category { get; set; } = [];
    public string Description { get; set; } = string.Empty;
    public string ImageFile { get; set; } = string.Empty;
    public decimal Price { get; set; }
}