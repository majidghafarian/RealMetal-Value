using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceApiController : ControllerBase
    {
        private readonly IPriceCalculator _calculator;


        public PriceApiController(IPriceCalculator calculator, IMetalPriceService metalService)
        {
            _calculator = calculator;
        }

        [HttpPost("calculate/live")]
        public async Task<ActionResult<PriceResult>> CalculateLive([FromBody] PriceInput input)
        {
            var result = _calculator.Calculate(input);
            return Ok(result);
        }
    }

}
