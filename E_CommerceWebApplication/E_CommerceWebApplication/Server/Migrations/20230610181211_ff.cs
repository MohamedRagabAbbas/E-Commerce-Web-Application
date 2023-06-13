using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceWebApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/element/40163/9843.png_300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/element/40020/0359.png_300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/element/40022/4914.png_300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/element/40202/6652.png_300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/original_origin_pic/18/12/29/b78f8119d4d12eca45c6a20ca94a8cc5.png_wh300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductImageUrl",
                value: "https://img.lovepik.com/element/40109/7776.png_300.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductImageUrl",
                value: "https://example.com/product1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductImageUrl",
                value: "https://example.com/product2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImageUrl",
                value: "https://example.com/product3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductImageUrl",
                value: "https://example.com/product4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductImageUrl",
                value: "https://example.com/product5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductImageUrl",
                value: "https://example.com/product6.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductImageUrl",
                value: "https://example.com/product7.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ProductAvailable", "ProductBrandId", "ProductCategoryId", "ProductColor", "ProductDescription", "ProductDiscount", "ProductGender", "ProductImageUrl", "ProductMaterial", "ProductName", "ProductPrice", "ProductQuantity", "ProductRating", "ProductSize" },
                values: new object[,]
                {
                    { 8, null, null, true, 1, 2, "Red", "This is the description for Product 8.", 10.0, "Women", "https://example.com/product8.jpg", "Polyester", "Product 8", 11.99, 80, 3, "Medium" },
                    { 9, null, null, true, 3, 1, "Green", "This is the description for Product 9.", 15.0, "Unisex", "https://example.com/product9.jpg", "Cotton", "Product 9", 16.989999999999998, 70, 5, "Large" },
                    { 10, null, null, true, 2, 3, "Black", "This is the description for Product 10.", 20.0, "Men", "https://example.com/product10.jpg", "Leather", "Product 10", 21.989999999999998, 40, 4, "Medium" }
                });
        }
    }
}
