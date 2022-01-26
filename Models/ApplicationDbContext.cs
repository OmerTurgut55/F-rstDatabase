using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=Database; Integrated Security=SSPI;";

            builder.UseSqlServer(connectionString);
        }
    }
}
