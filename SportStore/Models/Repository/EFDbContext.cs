using System.Data.Entity;

namespace SportStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        //Product model will be used to represent rows in the Product table
        public DbSet<Product> Products { get; set; }
    }
}