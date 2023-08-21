using Domain.Abstractions;
using Domain.Entities;
using Infrastructure.Query.Interfaces;

namespace Infrastructure.Queries.Products
{
    public sealed class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, Product>
    {
        protected readonly IProductRepository _ProductRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var product = await _ProductRepository.GetByIdAsync(request.Id, cancellationToken);

            if (product is not null)
            {
                var response = new Product(request.Id.ToString(), request.Title, request.Price);

                return response;
            }

            return null;
        }
    }
}
