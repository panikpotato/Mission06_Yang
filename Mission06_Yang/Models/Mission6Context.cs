using Microsoft.EntityFrameworkCore;

namespace Mission06_Yang.Models
{
    public class Mission6Context : DbContext
    {
        public Mission6Context(DbContextOptions<Mission6Context> options)
            : base(options)
        {
        }
        public DbSet<Application> Applications { get; set; }
    }
}
