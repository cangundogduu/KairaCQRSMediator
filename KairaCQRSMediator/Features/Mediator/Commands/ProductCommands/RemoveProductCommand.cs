using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand(int id) : IRequest
    {
        public int ProductId { get; set; } = id;

    }
}
