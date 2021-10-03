using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IWorkflowRepository Workflow { get; }

        int Complete();
    }
}