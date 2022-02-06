using Microsoft.EntityFrameworkCore;

namespace Core.Entities
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options){}

        public DbSet<Product> Products {get; set;}
    }
}