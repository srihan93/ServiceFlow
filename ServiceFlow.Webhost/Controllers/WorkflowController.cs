using Microsoft.AspNetCore.Mvc;
using ServiceFlow.DataAccess.OldDataAccess;
using ServiceFlow.Webhost.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceFlow.Webhost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : ControllerBase
    {
        private IDataService _dataService;

        public WorkflowController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/<WorkflowController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WorkflowController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WorkflowController>
        [HttpPost]
        public Workflow Post([FromBody] Workflow wf)
        {
            var id = _dataService.createWorkflow(wf.Name, wf.DisplayName);
            wf.Id = id;
            return wf;
        }

        // PUT api/<WorkflowController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkflowController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}