using Microsoft.EntityFrameworkCore;
using Sample.DataHub.Models.Domain;

namespace Sample.DataHub
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
