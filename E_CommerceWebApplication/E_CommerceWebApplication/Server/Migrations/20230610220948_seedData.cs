using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceWebApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryImageUrl", "CategoryName" },
                values: new object[,]
                {
                    { 1, "This is the description for T-Shirt.", "https://img.lovepik.com/element/40020/0359.png_300.png", "None" },
                    { 2, "This is the description for Shirt.", "https://img.lovepik.com/element/40022/4914.png_300.png", "Laptop" },
                    { 3, "This is the description for Jacket.", "https://img.lovepik.com/element/40202/6652.png_300.png", "Phone" },
                    { 4, "This is the description for Jacket.", "https://img.lovepik.com/element/40202/6652.png_300.png", "Watch" },
                    { 5, "This is the description for Jacket.", "https://img.lovepik.com/element/40202/6652.png_300.png", "Headphones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
