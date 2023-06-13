using E_CommerceWebApplication.Server.Data;
using E_CommerceWebApplication.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DBContextClass dbContext;
        public ProductService(DBContextClass _dbContext)
        {
            dbContext = _dbContext;
        }


        // Get Method
        public async Task<ServiceResponse<DisplayedProducts>> GetProductsByCategoryAsync(string categoryName, int pgaeNumber)
        {
            int _numberOfProducts = (await dbContext.Products.Where(p => p.Category.CategoryName.Equals(categoryName)).ToListAsync()).Count;
            int _numberOfPages = (int)Math.Ceiling(_numberOfProducts / 6.0);
            var prodcuts = await dbContext.Products.Where(p => p.Category.CategoryName.Equals(categoryName)).Skip((pgaeNumber - 1) * 6).Take(6).ToListAsync();
            var displayedProducts = new DisplayedProducts() { numberOfPages = _numberOfPages, pageNumber = pgaeNumber, products = prodcuts };

            if (prodcuts == null)
            {
                return new ServiceResponse<DisplayedProducts>
                {
                    Data = null,
                    Message = "No Product Found",
                    Success = false
                };
            }
            else
            {
                return new ServiceResponse<DisplayedProducts>
                {
                    Data = displayedProducts,
                    Message = "Product Found",
                    Success = true
                };
            }
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int Id)
        {
            var prodcuts = await dbContext.Products.FindAsync(Id);
            if (prodcuts == null)
            {
                return  new ServiceResponse<Product>
                {
                    Data = null,
                    Message = "No Product Found",
                    Success = false
                };
            }
            else
            {
                return new ServiceResponse<Product>
                {
                    Data = prodcuts,
                    Message = "Product Found",
                    Success = true
                };
            }
        }

        public async Task<ServiceResponse<DisplayedProducts>> GetProductsAsync(int pgaeNumber)
        {
            int _numberOfProducts = (await dbContext.Products.ToListAsync()).Count;
            int _numberOfPages =(int)Math.Ceiling(_numberOfProducts / 6.0);
            var prodcuts = await dbContext.Products.Skip((pgaeNumber - 1) * 6).Take(6).ToListAsync();

            var displayedProducts = new DisplayedProducts()  { numberOfPages = _numberOfPages, pageNumber = pgaeNumber, products = prodcuts };
            if (prodcuts == null)
            {
                return new ServiceResponse<DisplayedProducts>
                {
                    Data = null,
                    Message = "No Products Found",
                    Success = false
                };
            }
            else
            {
                return new ServiceResponse<DisplayedProducts>
                {
                    Data = displayedProducts,
                    Message = "Products Found",
                    Success = true
                };
            }
        }

        public async Task<ServiceResponse<List<Product>>> GetProductByNameAsync(string productName)
        {
            var prodcuts = await dbContext.Products.Where(p => p.ProductName.StartsWith(productName)).ToListAsync();
            if (prodcuts == null)
            {
                return new ServiceResponse<List<Product>>
                {
                    Data = null,
                    Message = "No Products Found",
                    Success = false
                };
            }
            else
            {
                return new ServiceResponse<List<Product>>
                {
                    Data = prodcuts,
                    Message = "Products Found",
                    Success = true
                };
            }
        }
    }
}
