using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC4.Services;


namespace VanhornBMC4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : ControllerBase
    {
         private readonly AddNumbers _addNumberServices;

         public NumberController(AddNumbers addNumberServices)
        {
            _addNumberServices = addNumberServices;
        }
         
        [HttpGet]
        [Route("AddingNumbers/{num1}/{num2}")]
        public string AddingNumbers(int num1, int num2)
        {
            return _addNumberServices.
            AddingNumbers(num1, num2);   
        }
    }
}