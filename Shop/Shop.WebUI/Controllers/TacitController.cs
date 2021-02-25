using Microsoft.AspNetCore.Mvc;
using Shop.Application.Features.TacitWorks.Tacit.Commands.CreateTacit;
using Shop.Application.Features.TacitWorks.Tacit.Queries.GetTacits;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacitController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<long>> Create(CreateTacitCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TacitVm>>> Get()
        {
            return Ok(await Mediator.Send(new GetTacitsQuery()));
        }
    }
}
