using Application.Input.Services.Requests.Interfaces;
using Application.Input.Services.Results;
using Application.Output.Services.ViewModels;

namespace Application.Input.Services.Requests
{
    public sealed class ProductRequest : IRequest
    {
        public ProductRequest(Result result, ProductViewModel product)
        {
            Result = result;
            Product = product;
        }

        public Result Result { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
