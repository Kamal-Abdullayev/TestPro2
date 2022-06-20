using Microsoft.EntityFrameworkCore;
using TestPro2.Model;

namespace TestPro2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
