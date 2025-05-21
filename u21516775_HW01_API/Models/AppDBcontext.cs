using Microsoft.EntityFrameworkCore;

namespace u21516775_HW01_API.Models
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {
        }

        public DbSet<ProductDetail> ProductDetails { get; set; }

        // protected AppDBcontext()
        // {
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail
                {
                    ProductId = 1,
                    ProductName = "Running Shoes",
                    Description = "Comfortable running shoes for long distances.",
                    Price = 89.99m
                },
                new ProductDetail
                {
                    ProductId = 2,
                    ProductName = "Wireless Headphones",
                    Description = "Noise-cancelling wireless headphones with long battery life.",
                    Price = 129.99m
                },
                new ProductDetail
                {
                    ProductId = 3,
                    ProductName = "Smartwatch",
                    Description = "Fitness tracker and smartwatch with health monitoring features.",
                    Price = 199.99m
                },
                new ProductDetail
                {
                    ProductId = 4,
                    ProductName = "Backpack",
                    Description = "Durable backpack with multiple compartments and laptop sleeve.",
                    Price = 49.99m
                },
                new ProductDetail
                {
                    ProductId = 5,
                    ProductName = "Water Bottle",
                    Description = "Insulated water bottle that keeps drinks cold for 24 hours.",
                    Price = 24.99m
                },
                new ProductDetail
                {
                    ProductId = 6,
                    ProductName = "Yoga Mat",
                    Description = "Non-slip yoga mat with carrying strap.",
                    Price = 29.99m
                },
                new ProductDetail
                {
                    ProductId = 7,
                    ProductName = "Protein Powder",
                    Description = "Whey protein powder with 25g protein per serving.",
                    Price = 39.99m
                },
                new ProductDetail
                {
                    ProductId = 8,
                    ProductName = "Resistance Bands",
                    Description = "Set of 5 resistance bands with different strengths.",
                    Price = 19.99m
                },
                new ProductDetail
                {
                    ProductId = 9,
                    ProductName = "Dumbbell Set",
                    Description = "Adjustable dumbbell set with various weight plates.",
                    Price = 149.99m
                },
                new ProductDetail
                {
                    ProductId = 10,
                    ProductName = "Fitness Tracker",
                    Description = "Simple fitness band that tracks steps, heart rate, and sleep.",
                    Price = 59.99m
                }
            );
        }
    }
}
