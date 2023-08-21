using Domain.Entities;
using Infrastructure.Query.Interfaces;

namespace Infrastructure.Queries.Products
{
    public sealed class GetProductByIdQuery : IQuery<Product>
    {
        public GetProductByIdQuery(Guid id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

}
