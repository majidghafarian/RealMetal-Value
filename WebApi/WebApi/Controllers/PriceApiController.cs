using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceApiController : ControllerBase
    {
        private readonly IMetalPriceCalculator _calculator;

        public PriceApiController(IMetalPriceCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("gold24")]
        public IActionResult GetGold24(double goldOunce, double dollar)
        {
            var result = _calculator.CalculateGold24(goldOunce, dollar);
            return Ok(result);
        }

        [HttpGet("gold18")]
        public IActionResult GetGold18(double goldOunce, double dollar)
        {
            var result = _calculator.CalculateGold18(goldOunce, dollar);
            return Ok(result);
        }

        [HttpGet("coin")]
        public IActionResult GetCoinEmami(double goldOunce, double dollar)
        {
            var result = _calculator.CalculateEmamiCoin(goldOunce, dollar);
            return Ok(result);
        }

        [HttpGet("silver")]
        public IActionResult GetSilver999(double silverOunce, double dollar)
        {
            var result = _calculator.CalculateSilver999(silverOunce, dollar);
            return Ok(result);
        }
    }
}

}
