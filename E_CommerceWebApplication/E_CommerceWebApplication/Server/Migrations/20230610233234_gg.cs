using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceWebApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class gg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ProductAvailable", "ProductBrandId", "ProductCategoryId", "ProductColor", "ProductDescription", "ProductDiscount", "ProductGender", "ProductImageUrl", "ProductMaterial", "ProductName", "ProductPrice", "ProductQuantity", "ProductRating", "ProductSize" },
                values: new object[,]
                {
                    { 1, null, null, true, 1, 1, "Red", "This is the description for Product 1.", 10.0, "Unisex", "https://img.lovepik.com/element/40163/9843.png_300.png", "Cotton", "Product 1", 9.9900000000000002, 100, 4, "Medium" },
                    { 2, null, null, true, 2, 2, "Blue", "This is the description for Product 2.", 15.0, "Men", "https://img.lovepik.com/element/40020/0359.png_300.png", "Polyester", "Product 2", 19.989999999999998, 50, 5, "Large" },
                    { 3, null, null, true, 3, 1, "Green", "This is the description for Product 3.", 20.0, "Women", "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png", "Silk", "Product 3", 14.99, 75, 4, "Small" },
                    { 4, null, null, true, 2, 3, "Black", "This is the description for Product 4.", 10.0, "Men", "https://img.lovepik.com/element/40022/4914.png_300.png", "Leather", "Product 4", 29.989999999999998, 30, 3, "Medium" },
                    { 5, null, null, true, 1, 2, "White", "This is the description for Product 5.", 5.0, "Women", "https://img.lovepik.com/element/40202/6652.png_300.png", "Cotton", "Product 5", 24.989999999999998, 60, 4, "Large" },
                    { 6, null, null, false, 3, 3, "Yellow", "This is the description for Product 6.", 0.0, "Unisex", "https://img.lovepik.com/original_origin_pic/18/12/29/b78f8119d4d12eca45c6a20ca94a8cc5.png_wh300.png", "Polyester", "Product 6", 39.990000000000002, 20, null, "Small" },
                    { 7, null, null, true, 2, 1, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Product 7", 49.990000000000002, 10, 4, "Large" }
                });
        }
    }
}
