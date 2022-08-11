using Microsoft.AspNetCore.Mvc;

namespace Relocation.Api.Controllers
{
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetClient(int id){
            throw new NotImplementedException();
        }
        
    }
}