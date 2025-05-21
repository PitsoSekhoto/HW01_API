using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u21516775_HW01_API.Controllers;
using u21516775_HW01_API.Models;
using Xunit;

namespace assignement1.Tests.Controller
{
    public class ProductsControllerTests
    {
        // Helper method to create an in-memory database context and seed data.
        private AppDBcontext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDBcontext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new AppDBcontext(options);

            // Seed test data (10 products)
            context.ProductDetails.AddRange(
                new ProductDetail { ProductId = 1, ProductName = "Test Product 1", Description = "Description 1", Price = 9.99m },
                new ProductDetail { ProductId = 2, ProductName = "Test Product 2", Description = "Description 2", Price = 19.99m },
                new ProductDetail { ProductId = 3, ProductName = "Test Product 3", Description = "Description 3", Price = 29.99m },
                new ProductDetail { ProductId = 4, ProductName = "Test Product 4", Description = "Description 4", Price = 39.99m },
                new ProductDetail { ProductId = 5, ProductName = "Test Product 5", Description = "Description 5", Price = 49.99m },
                new ProductDetail { ProductId = 6, ProductName = "Test Product 6", Description = "Description 6", Price = 59.99m },
                new ProductDetail { ProductId = 7, ProductName = "Test Product 7", Description = "Description 7", Price = 69.99m },
                new ProductDetail { ProductId = 8, ProductName = "Test Product 8", Description = "Description 8", Price = 79.99m },
                new ProductDetail { ProductId = 9, ProductName = "Test Product 9", Description = "Description 9", Price = 89.99m },
                new ProductDetail { ProductId = 10, ProductName = "Test Product 10", Description = "Description 10", Price = 99.99m }
            );
            context.SaveChanges();
            return context;
        }

        [Fact]
        public async Task GetProductDetails_ReturnsOkAndNotNull()
        {
            // Arrange: Create a fresh in-memory context and instantiate the controller.
            var context = CreateDbContext();
            var controller = new ProductDetailController(context);

            // Act: Call the GET endpoint for all products.
            var result = await controller.GetProductDetails();

            // Assert: Verify that the response is HTTP 200 OK and that the returned collection is not null.
            var actionResult = Assert.IsType<ActionResult<IEnumerable<ProductDetail>>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var products = Assert.IsAssignableFrom<IEnumerable<ProductDetail>>(okResult.Value);
            Assert.NotNull(products);
            Assert.Equal(10, products.Count());  // Verify that the seeded 10 products are returned.
        }

        [Fact]
        public async Task GetProductDetail_ReturnsOkAndNotNull()
        {
            // Arrange: Create a fresh in-memory context, and instantiate the controller with a seeded product.
            var context = CreateDbContext();
            var controller = new ProductDetailController(context);
            int productId = 1; // We know product with ID 1 is seeded.

            // Act: Call the GET endpoint for a product by its ID.
            var result = await controller.GetProductDetail(productId);

            // Assert: Verify that the response is HTTP 200 OK and that the returned product is not null.
            var actionResult = Assert.IsType<ActionResult<ProductDetail>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var product = Assert.IsAssignableFrom<ProductDetail>(okResult.Value);
            Assert.NotNull(product);
            Assert.Equal(productId, product.ProductId);
        }
    }
}
