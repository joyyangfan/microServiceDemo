using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class HealthController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("ok");
        }
    }
}
