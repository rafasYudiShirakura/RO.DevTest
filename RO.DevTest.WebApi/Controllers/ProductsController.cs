using Microsoft.AspNetCore.Mvc;
using MediatR;
using RO.DevTest.Application.Features.product.Commands.CreateProductCommand;
using RO.DevTest.Application.Features.product.Commands.UpdateProductCommand;
using RO.DevTest.Application.Features.product.Commands.DeleteProductCommand;

namespace RO.DevTest.WebApi.Controllers{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase{
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator){
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand command){
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, null);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id){
            return Ok(); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductCommand command){
            if (id != command.Id)
                return BadRequest("O id da url tem que ser igual ao da requisicao.");

            var result = await _mediator.Send(command);
            if (!result) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id){
            var result = await _mediator.Send(new DeleteProductCommand { Id = id });
            if (!result) return NotFound();

            return NoContent();
        }
    }
}
