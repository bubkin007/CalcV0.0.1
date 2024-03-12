using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add([FromBody] CalculationRequest request)
        {
            var response = new CalculationResponse
            {
                Result = request.Number1 + request.Number2
            };

            return Ok(response);
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalculationRequest request)
        {
            var response = new CalculationResponse
            {
                Result = request.Number1 - request.Number2
            };

            return Ok(response);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] CalculationRequest request)
        {

            var response = new CalculationResponse
            {
                Result = request.Number1 * request.Number2
            };

            return Ok(response);
        }

        [HttpPost("divide")]
        public IActionResult Divide([FromBody] CalculationRequest request)
        {

            if (request.Number2 == 0)
            {
                return BadRequest("Division by zero is not allowed");
            }

            var response = new CalculationResponse
            {
                Result = request.Number1 / request.Number2
            };

            return Ok(response);
        }
    }
}
