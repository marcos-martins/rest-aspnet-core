using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("{firstNUmber}/{secondNumber}")]
        public ActionResult<int> Get(int firstNUmber, int secondNumber)
        {
            return firstNUmber+ secondNumber;
        }
    }
}
