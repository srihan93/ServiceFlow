using ServiceFlow.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceFlow.DataAccess
{
    public class WorkflowRepository : Repository<Workflow>, IWorkflowRepository
    {
        public WorkflowRepository(ApplicationContext context) : base(context)
        {
        }

        public Workflow AddWorkflow(Workflow wf)
        {
            return _context.Workflow.ToList().FirstOrDefault();
        }

        public IEnumerable<Workflow> GetAllWorkflows()
        {
            return _context.Workflow.ToList();
        }
    }
}