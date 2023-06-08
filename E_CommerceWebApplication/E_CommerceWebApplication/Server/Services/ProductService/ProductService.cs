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
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryName)
        {
            var prodcuts = await dbContext.Products.Where(p=> p.Category.CategoryName.Equals(categoryName)).ToListAsync();
            if (prodcuts == null)
            {
                return new ServiceResponse<List<Product>>
                {
                    Data = null,
                    Message = "No Product Found",
                    Success = false
                };
            }
            else
            {
                return new ServiceResponse<List<Product>>
                {
                    Data = prodcuts,
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

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var prodcuts = await dbContext.Products.ToListAsync();
            if(prodcuts==null)
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
