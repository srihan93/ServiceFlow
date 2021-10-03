using ServiceFlow.DataAccess;
using ServiceFlow.DataAccess.AppDbContext;

namespace DataAccess.EFCore.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
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
            return Workflow.AddWorkflow()
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