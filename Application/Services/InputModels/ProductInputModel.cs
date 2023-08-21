using Domain.Entities;

namespace Application.Input.Services.InputModels
{
    public class ProductInputModel
    {
        public ProductInputModel(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product ToEntity()
            => new Product(
                Title,
                Description,
                Price
                );

    }
}