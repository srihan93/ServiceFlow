using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceFlow.Webhost.Controllers
{
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpPost]
        [RouteAttribute("api/status")]
        public IActionResult AddStatus()
        {
            return null;
        }

        [HttpPost]
        [RouteAttribute("api/reason")]
        public IActionResult AddReason()
        {
            return null;
        }

        [HttpPost]
        [RouteAttribute("api/status/reason")]
        public IActionResult MapReasonToStatus()
        {
            return null;
        }
    }
}