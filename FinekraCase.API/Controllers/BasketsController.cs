using FinekraCase.Application.Features.Baskets.DeleteBasket;
using FinekraCase.Application.Features.Baskets.SaveBasket;
using FinekraCase.Application.Features.Baskets.UpdateBasket;
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


        /// <summary>
        /// Update basket
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("")]
        public async Task UpdateAsync([FromBody] UpdateBasketCommand command)
        {
            await Mediator.Send(command);
        }


        /// <summary>
        /// Delete a basket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await Mediator.Send(new DeleteBasketCommand { Id = id });
        }

    }
}
