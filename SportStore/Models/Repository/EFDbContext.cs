using System.Data.Entity;

namespace SportStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}