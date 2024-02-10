using FinekraCase.Application.Features.Baskets.SaveBasket;
using Microsoft.AspNetCore.Mvc;

namespace FinekraCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ApiControllerBase
    {
        /// <summary>
        /// Add basket
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task SaveAsync([FromBody]SaveBasketCommand command)
        {
            await Mediator.Send(command);
        }
    }
}
