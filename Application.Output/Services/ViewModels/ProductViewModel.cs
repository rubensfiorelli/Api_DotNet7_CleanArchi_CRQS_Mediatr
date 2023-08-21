using Domain.Entities;

namespace Application.Output.Services.ViewModels
{
    public record ProductViewModel
    {
        public ProductViewModel(Guid id,
                                string title,
                                string description,
                                decimal price,
                                DateTime createAt,
                                DateTime updateAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            CreateAt = createAt;
            UpdateAt = updateAt;
        }

        public Guid Id { get; private init; }
        public string Title { get; private init; }
        public string Description { get; private init; }
        public decimal Price { get; private init; }
        public DateTime CreateAt { get; private init; }
        public DateTime UpdateAt { get; private init; }

        public static ProductViewModel FromEntity(Product product)
            => new(
                product.Id,
                product.Title,
                product.Description,
                product.Price,
                product.CreateAt,
                (DateTime)product.UpdateAt);


    }
}
