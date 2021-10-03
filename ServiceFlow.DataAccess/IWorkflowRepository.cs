using System.Collections.Generic;
using ServiceFlow.Common.DataModels;

namespace ServiceFlow.DataAccess
{
    public interface IWorkflowRepository : IRepository<Workflow>
    {
        IEnumerable<Workflow> GetAllWorkflows();

        Workflow AddWorkflow(Workflow wf);
    }
}