using Domain.Entities;

namespace Application.Input.Abstractions.Repositories
{
    public interface IProductWriteRepository
    {
        Task Insert(Product product);
    }
}
