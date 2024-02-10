using FinekraCase.Application.Features.Perfumes.Queries.GetFilterPerfumes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace FinekraCase.API.Controllers
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class PerfumesController : ApiControllerBase
    {
        [HttpGet("")]
        public async Task<ActionResult<List<PerfumesDto>>> GetFilterAsync([FromQuery] GetFilterPerfumesQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
