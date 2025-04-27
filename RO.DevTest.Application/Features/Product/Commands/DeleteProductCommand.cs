using MediatR;

namespace RO.DevTest.Application.Features.product.Commands.DeleteProductCommand {
    public class DeleteProductCommand : IRequest<bool> { 
        public Guid Id { get; set; }   
    }
}