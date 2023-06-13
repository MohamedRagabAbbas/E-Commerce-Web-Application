using E_CommerceWebApplication.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Server.Data
{
    public class DBContextClass:DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {

        }

         override  protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
     new List<Product>()
{
                new Product
                {
                    Id = 1,
                    ProductName = "Product 1",
                    ProductDescription = "This is the description for Product 1.",
                    ProductImageUrl = "https://img.lovepik.com/element/40163/9843.png_300.png",
                    ProductPrice = 9.99,
                    ProductQuantity = 100,
                    CategoryId = 1,
                    ProductBrandId = 1,
                    ProductColor = "Red",
                    ProductSize = "Medium",
                    ProductGender = "Unisex",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 10.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Product 2",
                    ProductDescription = "This is the description for Product 2.",
                    ProductImageUrl = "https://img.lovepik.com/element/40020/0359.png_300.png",
                    ProductPrice = 19.99,
                    ProductQuantity = 50,
                    CategoryId = 2,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Polyester",
                    ProductDiscount = 15.0,
                    ProductAvailable = true,
                    ProductRating = 5
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Product 3",
                    ProductDescription = "This is the description for Product 3.",
                    ProductImageUrl = "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png",
                    ProductPrice = 14.99,
                    ProductQuantity = 75,
                    CategoryId = 1,
                    ProductBrandId = 3,
                    ProductColor = "Green",
                    ProductSize = "Small",
                    ProductGender = "Women",
                    ProductMaterial = "Silk",
                    ProductDiscount = 20.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Product 4",
                    ProductDescription = "This is the description for Product 4.",
                    ProductImageUrl = "https://img.lovepik.com/element/40022/4914.png_300.png",
                    ProductPrice = 29.99,
                    ProductQuantity = 30,
                    CategoryId = 3,
                    ProductBrandId = 2,
                    ProductColor = "Black",
                    ProductSize = "Medium",
                    ProductGender = "Men",
                    ProductMaterial = "Leather",
                    ProductDiscount = 10.0,
                    ProductAvailable = true,
                    ProductRating = 3
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Prodnnuct 5",
                    ProductDescription = "This is the description for Product 5.",
                    ProductImageUrl = "https://img.lovepik.com/element/40202/6652.png_300.png",
                    ProductPrice = 24.99,
                    ProductQuantity = 60,
                    CategoryId = 2,
                    ProductBrandId = 1,
                    ProductColor = "White",
                    ProductSize = "Large",
                    ProductGender = "Women",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                 new Product
                {
                     Id = 6,
                    ProductName = "Prhhoduct 3",
                    ProductDescription = "This is the description for Product 3.",
                    ProductImageUrl = "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png",
                    ProductPrice = 14.99,
                    ProductQuantity = 75,
                    CategoryId = 3,
                    ProductBrandId = 3,
                    ProductColor = "Green",
                    ProductSize = "Small",
                    ProductGender = "Women",
                    ProductMaterial = "Silk",
                    ProductDiscount = 20.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 7,
                    ProductName = "Prorrduct 7",
                    ProductDescription = "This is the description for Product 7.",
                    ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
                    ProductPrice = 49.99,
                    ProductQuantity = 10,
                    CategoryId = 4,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 8,
                    ProductName = "Prodmuct 7",
                    ProductDescription = "This is the description for Product 7.",
                    ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
                    ProductPrice = 49.99,
                    ProductQuantity = 10,
                    CategoryId = 5,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 9,
                    ProductName = "Pronduct 6",
                    ProductDescription = "This is the description for Product 6.",
                    ProductImageUrl = "https://img.lovepik.com/original_origin_pic/18/12/29/b78f8119d4d12eca45c6a20ca94a8cc5.png_wh300.png",
                    ProductPrice = 39.99,
                    ProductQuantity = 20,
                    CategoryId = 3,
                    ProductBrandId = 3,
                    ProductColor = "Yellow",
                    ProductSize = "Small",
                    ProductGender = "Unisex",
                    ProductMaterial = "Polyester",
                    ProductDiscount = 0.0,
                    ProductAvailable = false,
                    ProductRating = null
                },
                new Product
                {
                    Id = 10,
                    ProductName = "Prodhuct 7",
                    ProductDescription = "This is the description for Product 7.",
                    ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
                    ProductPrice = 49.99,
                    ProductQuantity = 10,
                    CategoryId = 1,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                 new Product
                {
                     Id = 11,
                    ProductName = "Prodtuct 3",
                    ProductDescription = "This is the description for Product 3.",
                    ProductImageUrl = "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png",
                    ProductPrice = 14.99,
                    ProductQuantity = 75,
                    CategoryId = 3,
                    ProductBrandId = 3,
                    ProductColor = "Green",
                    ProductSize = "Small",
                    ProductGender = "Women",
                    ProductMaterial = "Silk",
                    ProductDiscount = 20.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 12,
                    ProductName = "Produfct 7",
                    ProductDescription = "This is the description for Product 7.",
                    ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
                    ProductPrice = 49.99,
                    ProductQuantity = 10,
                    CategoryId = 2,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
                new Product
                {
                    Id = 13,
                    ProductName = "Prosduct 7",
                    ProductDescription = "This is the description for Product 7.",
                    ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
                    ProductPrice = 49.99,
                    ProductQuantity = 10,
                    CategoryId = 1,
                    ProductBrandId = 2,
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductGender = "Men",
                    ProductMaterial = "Cotton",
                    ProductDiscount = 5.0,
                    ProductAvailable = true,
                    ProductRating = 4
                },
          new Product
          {
              Id = 14,
              ProductName = "Prodduct 3",
              ProductDescription = "This is the description for Product 3.",
              ProductImageUrl = "https://img.lovepik.com/original_origin_pic/18/11/27/edf7eaa41e16a9c50cf88d82dae560dd.png_wh300.png",
              ProductPrice = 14.99,
              ProductQuantity = 75,
              CategoryId = 2,
              ProductBrandId = 3,
              ProductColor = "Green",
              ProductSize = "Small",
              ProductGender = "Women",
              ProductMaterial = "Silk",
              ProductDiscount = 20.0,
              ProductAvailable = true,
              ProductRating = 4
          },
        new Product
        {
            Id = 15,
            ProductName = "Prxoduct 7",
            ProductDescription = "This is the description for Product 7.",
            ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
            ProductPrice = 49.99,
            ProductQuantity = 10,
            CategoryId = 4,
            ProductBrandId = 4,
            ProductColor = "Blue",
            ProductSize = "Large",
            ProductGender = "Men",
            ProductMaterial = "Cotton",
            ProductDiscount = 5.0,
            ProductAvailable = true,
            ProductRating = 4
        },
        new Product
        {
            Id = 16,
            ProductName = "Producxt 7",
            ProductDescription = "This is the description for Product 7.",
            ProductImageUrl = "https://img.lovepik.com/element/40109/7776.png_300.png",
            ProductPrice = 49.99,
            ProductQuantity = 10,
            CategoryId = 3,
            ProductBrandId = 2,
            ProductColor = "Blue",
            ProductSize = "Large",
            ProductGender = "Men",
            ProductMaterial = "Cotton",
            ProductDiscount = 5.0,
            ProductAvailable = true,
            ProductRating = 4
        } }
     );

            modelBuilder.Entity<Category>().HasData(
                new List<Category>()
                {
                    new Category
                    {
                        Id = 1,
                        CategoryName = "None",
                        CategoryDescription = "This is the description for T-Shirt.",
                        CategoryImageUrl = "https://img.lovepik.com/element/40020/0359.png_300.png",
                    },
                    new Category
                    {
                        Id = 2,
                        CategoryName = "Laptop",
                        CategoryDescription = "This is the description for Shirt.",
                        CategoryImageUrl = "https://img.lovepik.com/element/40022/4914.png_300.png",
                    },
                    new Category
                    {
                        Id = 3,
                        CategoryName = "Phone",
                        CategoryDescription = "This is the description for Jacket.",
                        CategoryImageUrl = "https://img.lovepik.com/element/40202/6652.png_300.png",
                    },
                    new Category
                    {
                        Id = 4,
                        CategoryName = "Watch",
                        CategoryDescription = "This is the description for Jacket.",
                        CategoryImageUrl = "https://img.lovepik.com/element/40202/6652.png_300.png",
                    },
                    new Category
                    {
                        Id = 5,
                        CategoryName = "Headphones",
                        CategoryDescription = "This is the description for Jacket.",
                        CategoryImageUrl = "https://img.lovepik.com/element/40202/6652.png_300.png",
                    }
                }
                );



        }

        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }

    }
}
