using Microsoft.EntityFrameworkCore;

namespace ThirdTemplateforfoodordering.Models
{
    public class FoodContext:DbContext
    {
        public FoodContext() { }
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
