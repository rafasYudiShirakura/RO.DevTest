using MediatR;

namespace RO.DevTest.Application.Features.product.Commands.CreateProductCommand
{
	public class CreateProductCommand : IRequest<Guid>
	{
		public string Name { get; set; } = default!;
		public decimal Price { get; set; }
		public int Stock { get; set; }
	}


}