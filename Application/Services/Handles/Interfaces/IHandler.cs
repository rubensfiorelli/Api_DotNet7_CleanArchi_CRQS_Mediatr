using Application.Input.Services.Commands.Interfaces;
using Application.Input.Services.Results;

namespace Application.Input.Services.Handles.Interfaces
{
    public interface IHandler<in TCommand> where TCommand : ICommand
    {
        Task<Result> Handle(TCommand command);
    }
}
