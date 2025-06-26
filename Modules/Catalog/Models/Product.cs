using Catalog.Products.Events;

namespace Catalog.Models;

//* Inheriting from 'Aggregate' allows domain events to be raised
public class Product : Aggregate<Guid>
{
    //* 'private set' ensures properties can only be modified through the controlled methods
    public string Name { get; private set; } = string.Empty;
    public List<string> Category { get; private set; } = [];
    public string Description { get; private set; } = string.Empty;
    public string ImageFile { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public static Product Create(
        Guid id,
        string name,
        List<string> category,
        string description,
        string imageFile,
        decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        var product = new Product
        {
            Id = id,
            Name = name,
            Category = category,
            Description = description,
            ImageFile = imageFile,
            Price = price,
        };

        //* Raising domain event
        product.AddDomainEvent(new ProductCreatedEvent(product));

        return product;
    }

    public void Update(
        string name,
        List<string> category,
        string description,
        string imageFile,
        decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        Name = name;
        Category = category;
        Description = description;
        ImageFile = imageFile;
        Price = price;

        if (Price != price)
        {
            Price = price;
            AddDomainEvent(new ProductPriceChangeEvent(this));
        }
    }
}