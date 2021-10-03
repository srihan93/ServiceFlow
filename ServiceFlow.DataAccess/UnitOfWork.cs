using ServiceFlow.DataAccess;
using ServiceFlow.Common.DataModels;

namespace DataAccess.EFCore.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Workflow = new WorkflowRepository(_context);
        }

        public IWorkflowRepository Workflow { get; private set; }

        public Workflow CreateWorkflow(string Name, string DisplayName)
        {
            var wf = new Workflow();
            wf.Id = new System.Guid();
            wf.DisplayName = DisplayName;
            wf.Name = Name;
            return null;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}