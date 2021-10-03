using ServiceFlow.DataAccess.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess
{
    internal class WorkflowRepository : Repository<Workflow>, IWorkflowRepository
    {
        public WorkflowRepository(AppDbContext.AppDbContext context)
        {
        }

        public Workflow AddWorkflow(string Name, string DisplayName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Workflow> GetAllWorkflows()
        {
            throw new NotImplementedException();
        }
    }
}