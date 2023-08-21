using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    }
}
