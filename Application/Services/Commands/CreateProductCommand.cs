using Application.Input.Services.Commands.Interfaces;

namespace Application.Input.Services.Commands
{
    public sealed record CreateProductCommand : ICommand
    {
        public CreateProductCommand(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; private init; }
        public string Description { get; private init; }
        public decimal Price { get; private init; }


    }
}
