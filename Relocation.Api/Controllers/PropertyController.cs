using MediatR;
using Microsoft.AspNetCore.Mvc;
using Relocation.Domain.Property.Entity;

namespace Relocation.Api.Controllers
{
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        public IMediator _mediator;

        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProperty(Guid id){
            return Ok(new PropertyEntity());

        }
    }
}