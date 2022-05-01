using Microsoft.EntityFrameworkCore;

namespace bookannotation_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User>? Users { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Note>? Notes { get; set; }
    }
}