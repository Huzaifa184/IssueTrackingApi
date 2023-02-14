using Microsoft.EntityFrameworkCore;
using trackingapi1.Models;

namespace trackingapi1.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
