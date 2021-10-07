using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceFlow.Common.DataModels;
using ServiceFlow.DataAccess.OldDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceFlow.Webhost.Controllers
{
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IDataService _dataService;

        public StatusController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        [RouteAttribute("api/status")]
        public IActionResult AddStatus()
        {
            return null;
        }

        [HttpPost]
        [RouteAttribute("api/reason/{reasonId}")]
        public IActionResult AddReason(Guid reasonId, Reason reason)
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