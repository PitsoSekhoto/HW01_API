using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21516775_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Comfortable running shoes for long distances.", 89.99m, "Running Shoes" },
                    { 2, "Noise-cancelling wireless headphones with long battery life.", 129.99m, "Wireless Headphones" },
                    { 3, "Fitness tracker and smartwatch with health monitoring features.", 199.99m, "Smartwatch" },
                    { 4, "Durable backpack with multiple compartments and laptop sleeve.", 49.99m, "Backpack" },
                    { 5, "Insulated water bottle that keeps drinks cold for 24 hours.", 24.99m, "Water Bottle" },
                    { 6, "Non-slip yoga mat with carrying strap.", 29.99m, "Yoga Mat" },
                    { 7, "Whey protein powder with 25g protein per serving.", 39.99m, "Protein Powder" },
                    { 8, "Set of 5 resistance bands with different strengths.", 19.99m, "Resistance Bands" },
                    { 9, "Adjustable dumbbell set with various weight plates.", 149.99m, "Dumbbell Set" },
                    { 10, "Simple fitness band that tracks steps, heart rate, and sleep.", 59.99m, "Fitness Tracker" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "ProductDetails",
               keyColumn: "ProductId",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductId",
                keyValue: 10);
        }
    }
}
