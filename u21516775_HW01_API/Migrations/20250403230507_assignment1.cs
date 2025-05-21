using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21516775_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class assignment1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "High-performance sports shoes designed for optimal comfort.", 95.50m, "Sports Shoes" },
                    { 2, "Wireless over-ear headphones with immersive sound quality.", 150.00m, "Over-Ear Headphones" },
                    { 3, "Advanced smartwatch featuring fitness tracking and notifications.", 220.00m, "Advanced Smartwatch" },
                    { 4, "Ergonomic backpack with padded straps and multiple pockets.", 55.00m, "Ergonomic Backpack" },
                    { 5, "Eco-friendly insulated water bottle that keeps beverages cold for hours.", 30.00m, "Eco-friendly Water Bottle" },
                    { 6, "Premium yoga mat with extra cushioning and non-slip surface.", 35.00m, "Premium Yoga Mat" },
                    { 7, "High-quality plant-based protein powder for muscle recovery.", 45.00m, "Plant-based Protein Powder" },
                    { 8, "Durable resistance bands set with varying resistance levels.", 25.00m, "Resistance Bands Set" },
                    { 9, "Adjustable dumbbell set for versatile strength training.", 160.00m, "Adjustable Dumbbell Set" },
                    { 10, "Smart fitness tracker that monitors heart rate and activity.", 65.00m, "Smart Fitness Tracker" }
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
