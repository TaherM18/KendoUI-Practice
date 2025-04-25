using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/state")]
    public class StateApiController : ControllerBase
    {
        private readonly List<StateModel> states = new List<StateModel> {
            new StateModel { Id = 1, Name = "Gujarat", Code = "GJ" },
            new StateModel { Id = 2, Name = "Maharashtra", Code = "MH" },
            new StateModel { Id = 3, Name = "Punjab", Code = "PB" },
        };
        
        [HttpGet]
        public IActionResult GetStates()
        {
            return Ok(new { data = states });
        }
    }
}