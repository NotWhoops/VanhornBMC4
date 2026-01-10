using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VanhornBMC4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterOrLessController : ControllerBase
    {
        [HttpGet]
        [Route("BiggerNumbers/{num1}/{num2}")]
        public string BiggerNumbers(int num1, int num2)
        {
            return _GreaterOrLessThanServices.
            BiggerNumbers(num1, num2);   
        }
        [HttpGet]
        [Route("SmallerNumbers/{num1}/{num2}")]
        public string SmallerNumbers(int num1, int num2)
        {
            return _GreaterOrLessThanServices.
            SmallerNumbers(num1, num2);   
        }
    }
}