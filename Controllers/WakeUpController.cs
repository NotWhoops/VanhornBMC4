using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VanhornBMC4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WakeUpController : ControllerBase
    {
        private readonly WakeUp _wakeUpServices;

         public WakeUpController(WakeUp wakeUpServices)
        {
            _wakeUpServices = wakeUpServices;
        }
        [HttpGet]
        [Route("WakeUp/{name}/{TimeWakedUp}")]
        public string WakeUp(string name, string TimeWakedUp)
        {
            return _wakeUpServices.
            WakeUp(name, TimeWakedUp);
        }
    }
}