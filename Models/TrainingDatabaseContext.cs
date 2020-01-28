using Microsoft.EntityFrameworkCore;

namespace TrainingProject.Models
{
    public class TrainingDatabaseContext : DbContext
    {
        public TrainingDatabaseContext(DbContextOptions<TrainingDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<TrainingDatabase> TodoItems { get; set; }
    }
}