using MediatR;
using Microsoft.EntityFrameworkCore;
using RO.DevTest.Application.Contracts.Persistence;

namespace RO.DevTest.Application.Features.product.Commands.DeleteProductCommand {
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool> {
        private readonly DefaultContext _context;
        public DeleteProductCommandHandler(DefaultContext context) {
            _context = context;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken) {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if (product == null) {
                return false;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

    }
}