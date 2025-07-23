using Microsoft.EntityFrameworkCore;

namespace Healthcareproject.Models
{
    public class AppDbContext : DbContext

    {
        public DbSet<Product> Products { get; set; }
     /*   private readonly IConfiguration _configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
     */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=healthcare;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
