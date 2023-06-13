using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceWebApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 5, null, null, true, 1, 2, "White", "This is the description for Product 5.", 5.0, "Women", "https://img.lovepik.com/element/40202/6652.png_300.png", "Cotton", "Prodnnuct 5", 24.989999999999998, 60, 4, "Large" },
                    { 6, null, null, true, 3, 3, "Green", "This is the description for Product 3.", 20.0, "Women", "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png", "Silk", "Prhhoduct 3", 14.99, 75, 4, "Small" },
                    { 7, null, null, true, 2, 4, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Prorrduct 7", 49.990000000000002, 10, 4, "Large" },
                    { 8, null, null, true, 2, 5, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Prodmuct 7", 49.990000000000002, 10, 4, "Large" },
                    { 9, null, null, false, 3, 3, "Yellow", "This is the description for Product 6.", 0.0, "Unisex", "https://img.lovepik.com/original_origin_pic/18/12/29/b78f8119d4d12eca45c6a20ca94a8cc5.png_wh300.png", "Polyester", "Pronduct 6", 39.990000000000002, 20, null, "Small" },
                    { 10, null, null, true, 2, 1, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Prodhuct 7", 49.990000000000002, 10, 4, "Large" },
                    { 11, null, null, true, 3, 3, "Green", "This is the description for Product 3.", 20.0, "Women", "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png", "Silk", "Prodtuct 3", 14.99, 75, 4, "Small" },
                    { 12, null, null, true, 2, 2, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Produfct 7", 49.990000000000002, 10, 4, "Large" },
                    { 13, null, null, true, 2, 1, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Prosduct 7", 49.990000000000002, 10, 4, "Large" },
                    { 14, null, null, true, 3, 2, "Green", "This is the description for Product 3.", 20.0, "Women", "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png", "Silk", "Prodduct 3", 14.99, 75, 4, "Small" },
                    { 15, null, null, true, 4, 4, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Prxoduct 7", 49.990000000000002, 10, 4, "Large" },
                    { 16, null, null, true, 2, 3, "Blue", "This is the description for Product 7.", 5.0, "Men", "https://img.lovepik.com/element/40109/7776.png_300.png", "Cotton", "Producxt 7", 49.990000000000002, 10, 4, "Large" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
