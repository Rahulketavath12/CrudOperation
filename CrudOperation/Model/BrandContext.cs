using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Model
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) :base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
