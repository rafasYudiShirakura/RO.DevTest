using MediatR;

namespace RO.DevTest.Application.Features.product.Commands.UpdateProductCommand {
    public class UpdateProductCommand : IRequest<bool> { 
        public Guid id { get; set; }
        public string Name { get; set; } = default;
        public decimal Price { get; set; } 
        public int Stock { get; set; }
    }
}