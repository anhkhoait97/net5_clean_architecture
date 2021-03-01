using Microsoft.AspNetCore.Mvc;
using Shop.Application.Features.TacitWorks.TacitFeature.Commands.CreateTacit;
using Shop.Application.Features.TacitWorks.TacitFeature.Commands.SearchTacit;
using Shop.Application.Features.TacitWorks.TacitFeature.Commands.UpdateTacit;
using Shop.Application.Features.TacitWorks.TacitFeature.Queries.GetTacits;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacitController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TacitVm>>> Get()
        {
            return Ok(await Mediator.Send(new GetTacitsQuery()));
        }


        [HttpPost("search-tacit")]
        public async Task<ActionResult<IEnumerable<SearchTacitRespone>>> Search(SearchTacitCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost]
        public async Task<ActionResult<long>> Create(CreateTacitCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut]
        public async Task<ActionResult<long>> Update(UpdateTacitCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
