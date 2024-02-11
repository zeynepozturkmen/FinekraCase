using FinekraCase.Application.Features.Order.SaveOrder;
using Microsoft.AspNetCore.Mvc;

namespace FinekraCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ApiControllerBase
    {
        /// <summary>
        /// Save Order
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task SaveAsync([FromBody] SaveOrderCommand command)
        {
            await Mediator.Send(command);
        }
    }
}
