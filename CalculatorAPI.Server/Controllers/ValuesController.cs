using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(double x, double y) => Ok(x + y);

        [HttpGet("subtract")]
        public IActionResult Subtract(double x, double y) => Ok(x - y);

        [HttpGet("multiply")]
        public IActionResult Multiply(double x, double y) => Ok(x * y);

        [HttpGet("divide")]
        public IActionResult Divide(double x, double y)
        {
            if (y == 0) return BadRequest("Cannot divide by zero.");
            return Ok(x / y);
        }
    }
}

namespace ReactApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
    }
}

namespace CalculatorAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
    }
}
