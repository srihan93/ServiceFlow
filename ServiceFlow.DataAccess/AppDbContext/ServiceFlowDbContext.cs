using Microsoft.EntityFrameworkCore;

namespace ServiceFlow.DataAccess.AppDbContext
{
    public class ServiceFlowDbContext : DbContext
    {
        public ServiceFlowDbContext(DbContextOptions<ServiceFlowDbContext> options) : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Reason> Reason { get; set; }
        public DbSet<ReasonInStatus> ReasonInStatus { get; set; }
        public DbSet<Workflow> Workflow { get; set; }
        public DbSet<WorkflowConfiguration> WorkflowConfiguration { get; set; }
        public DbSet<Attribute> Attribute { get; set; }
    }
}