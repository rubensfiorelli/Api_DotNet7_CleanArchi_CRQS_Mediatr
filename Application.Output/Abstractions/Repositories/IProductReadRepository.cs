using Application.Output.Services.ViewModels;

namespace Application.Output.Abstractions.Repositories
{
    public interface IProductReadRepository
    {
        Task<ICollection<ProductViewModel>> GetAll();
    }
}
