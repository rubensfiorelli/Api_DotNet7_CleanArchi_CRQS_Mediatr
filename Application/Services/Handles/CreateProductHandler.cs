using Application.Input.Abstractions.Repositories;
using Application.Input.Services.Commands;
using Application.Input.Services.Handles.Interfaces;
using Application.Input.Services.InputModels;
using Application.Input.Services.Results;
using Domain.Abstractions;
using Domain.Notifications;

namespace Application.Input.Services.Handles
{
    public sealed class CreateProductHandler : IHandler<CreateProductCommand>
    {
        private readonly IProductWriteRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductHandler(IProductWriteRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(CreateProductCommand command)
        {
            var product = new ProductInputModel(command.Title, command.Description, command.Price);
            Result result;

            var modelToEntity = product.ToEntity();

            if (!modelToEntity.IsValid())
                return new Result(400, "Erro ao inserir evento", modelToEntity.Notifications);

            if (modelToEntity.IsValid())
            {
                try
                {
                    await _productRepository.Insert(modelToEntity);
                    await _unitOfWork.Commit();

                    result = new Result(201, "Evento criado com sucesso", modelToEntity);
                    result.AddNotification(modelToEntity.Notifications as List<Notification>);
                    return result;

                }
                catch (Exception ex)
                {
                    _ = new Result(500, ex.Message, null);
                }

            }
            result = new Result(400, $"Falha ao inserir {modelToEntity.Title}", false);
            result.AddNotification(modelToEntity.Notifications as List<Notification>);
            return result;

        }


    }
}
