using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess
{
    public interface IWorkflowRepository : IRepository<Workflow>
    {
        IEnumerable<Workflow> GetAllWorkflows();

        Workflow AddWorkflow(string Name, string DisplayName);
    }
}