using MediatR;
using Microsoft.EntityFrameworkCore;
using RO.DevTest.Application.Contracts.Persistence;

namespace RO.DevTest.Aplication.Features.Product.Commands.UpdateProductCommand {
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool> {
        private readonly DefaultContext _context;
        public UpdateProductCommandHandler(DefaultContext context) {
            _context = context;
        }
        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken) {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if (product == null) { 
                return false;
 
            }
            product.Name = request.Name;
            product.Price = request.Price;
            product.Stock = request.Stock;

            _context.Products.Update(product);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}