using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC4.Services
{
    public class WakeUpServices
    {
        public string WakeUp(string name, string TimeWakedUp)
        {
            return $"Hello {name} you woke up at {TimeWakedUp}";
        }
    }
}