using Microsoft.AspNetCore.Mvc;
using MediatR;
using Relocation.Application.CommandHandler.CreateClient.Input;

namespace Relocation.Api.Controllers
{
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        public IMediator _mediatr;         

        public ClientController(IMediator mediator)
        {
            _mediatr = mediator;
        } 

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetClient(int id){
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientCommandRequest input){
            await _mediatr.Send(input);

            return new CreatedResult(Request.Path, null);
        }
        
    }
}