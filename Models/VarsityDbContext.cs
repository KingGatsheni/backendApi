using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class VarsityDbContext:DbContext
    {
        public VarsityDbContext(DbContextOptions<VarsityDbContext> options):base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}