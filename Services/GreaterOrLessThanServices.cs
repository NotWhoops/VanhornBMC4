using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC4.Services
{
    public class GreaterOrLessThanServices
    {
        public string BiggerNumbers(int num1, int num2)
        {
            return $"{num1} > {num2} = {num1} > {num2}";
        }
        public string SmallerNumbers(int num1, int num2)
        {
            return $"{num1} < {num2} = {num1} < {num2}";
        }
    }
}