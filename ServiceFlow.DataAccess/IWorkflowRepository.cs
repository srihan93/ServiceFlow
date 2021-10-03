using System.Collections.Generic;

namespace ServiceFlow.DataAccess
{
    public interface IWorkflowRepository : IRepository<Workflow>
    {
        IEnumerable<Workflow> GetAllWorkflows();

        Workflow AddWorkflow(Workflow wf);
    }
}