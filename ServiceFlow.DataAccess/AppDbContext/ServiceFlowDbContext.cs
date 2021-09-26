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
    }
}