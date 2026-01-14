using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC4.Services
{
    public class AddNumbersServices
    {
        public string AddingNumbers(int num1, int num2)
        {
            return $"the sum of {num1} + {num2} = {num1 + num2}";
        }
    }
}