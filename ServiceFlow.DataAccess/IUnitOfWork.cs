using System;

namespace ServiceFlow.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IWorkflowRepository Workflow { get; }

        int Complete();
    }
}