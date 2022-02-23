namespace Calculator.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Calculator.Library;
    using System;

    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorEvents _calculatorEvents;

        public CalculatorController()
        {
            _calculatorEvents = new CalculatorEvents();
        }

        //AdditionTask Api EndPoint
        [HttpGet("api/add/{x}/{y}")]
        public IActionResult AdditionTask(int x,int y)
        {
            try
            {
                var result = _calculatorEvents.Addition(x, y);
                return Ok(result); // will return result with Status code 200
            }
            catch (Exception)
            {
                return StatusCode(400); // will return Status code 400 with Exception
            }
        }

        //SubtractionTask Api EndPoint
        [HttpGet("api/minus/{x}/{y}")]
        public IActionResult SubtractionTask(int x, int y)
        {
            try
            {
                var result = _calculatorEvents.Subtraction(x, y);
                return Ok(result); // will return result with Status code 200
            }
            catch (Exception)
            {
                return StatusCode(400); // will return Status code 400 with Exception
            }
        }

        //MultiplicationTask Api EndPoint
        [HttpGet("api/multiple/{x}/{y}")]
        public IActionResult MultiplicationTask(int x, int y)
        {
            try
            {
                var result = _calculatorEvents.Multiplication(x, y);
                return Ok(result); // will return result with Status code 200
            }
            catch (Exception)
            {
                return StatusCode(400); // will return Status code 400 with Exception
            }
        }

        //Division Api EndPoint
        [HttpGet("api/divide/{x}/{y}")]
        public IActionResult DivisionTask(int x, int y)
        {
            try
            {
                var result = _calculatorEvents.Division(x, y);
                return Ok(result); // will return result with Status code 200
            }
            catch (Exception)
            {
                return StatusCode(400); // will return Status code 400 with Exception
            }
        }
    }
}
