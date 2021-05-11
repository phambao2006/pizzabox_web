using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
    public class PizzaBoxContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Topping> Toppings { get; set; }

        public PizzaBoxContext() { }
        public PizzaBoxContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pizza>().HasKey(e => e.EntityID);

            builder.Entity<Store>().HasKey(e => e.EntityID);

            builder.Entity<Customer>().HasKey(e => e.EntityID);

            builder.Entity<Order>().HasKey(e => e.EntityID);

            builder.Entity<Crust>().HasKey(e => e.EntityID);

            builder.Entity<Topping>().HasKey(e => e.EntityID);

            builder.Entity<Size>().HasKey(e => e.EntityID);

            //relationship
            builder.Entity<Pizza>().HasOne(p => p.Crust).WithMany(c => c.Pizzas).HasForeignKey(p => p.CrustEntityId);
            builder.Entity<Pizza>().HasOne(p => p.Size).WithMany(s => s.Pizzas).HasForeignKey(p => p.SizeEntityId);
            builder.Entity<Pizza>().HasOne<Order>().WithMany(o => o.Pizzas).HasForeignKey(p => p.OrderEntityId);

            OnModelSeeding(builder);
        }

        private static void OnModelSeeding(ModelBuilder builder)
        {
            builder.Entity<Crust>().HasData(new[]
            {
                new Crust {EntityID =1,Name="Original",Price = 2},
                new Crust {EntityID=2,Name="Thin Crust",Price = 2},
                new Crust {EntityID=3,Name="Stuffed Crust",Price = 2}
            });
            builder.Entity<Size>().HasData(new[]
      {
                new Size {EntityID=1,Name="Small",Price = 2},
                new Size {EntityID=2,Name="Medium",Price = 3},
                new Size {EntityID=3,Name="Large",Price = 4}
            });

            builder.Entity<Topping>().HasData(new[]
      {
                new Topping {EntityID=1,Name="Chicken",Price = 2},
                new Topping {EntityID=2,Name="Beef",Price = 2},
                new Topping {EntityID=3,Name="Pork",Price = 2},
                new Topping {EntityID=4,Name="Pineapple",Price = 2},
                new Topping {EntityID=5,Name="Bell Pepper",Price = 2},
                new Topping {EntityID=6,Name="Mushroom",Price = 2}
            });
            builder.Entity<Store>().HasData(new[]
            {
                new Store {EntityID=1,Name="DownTown"},
                new Store {EntityID=2,Name="Times Square"},
                new Store {EntityID=3,Name="Central"}
            });
        }
    }
}
