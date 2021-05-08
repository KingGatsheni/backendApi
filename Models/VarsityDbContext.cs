using System.Linq;
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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            foreach(var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())){
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }
}