using MediatR;
using RO.DevTest.Domain.Entities;
using RO.DevTest.Infrastructure.Persistence; 

namespace RO.DevTest.Application.Features.Product.Commands.CreateProductCommand
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandHandler, Guid>
    {
        private readonly DefaultContext _context;

        public CreateProductCommandHandler(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync(cancellationToken);

            return product.Id;
        }

        public Task<Guid> Handle(CreateProductCommandHandler request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
