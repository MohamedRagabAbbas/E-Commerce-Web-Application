using E_CommerceWebApplication.Server.Data;
using E_CommerceWebApplication.Shared.Models;

namespace E_CommerceWebApplication.Server.Services.ProductService
{
    public interface IProductService
    {
        public Task<ServiceResponse<DisplayedProducts>> GetProductsAsync(int pgaeNumber);
        public Task<ServiceResponse<DisplayedProducts>> GetProductsByCategoryAsync(string categoryName, int pgaeNumber);



        public Task<ServiceResponse<Product>> GetProductByIdAsync(int Id);
        public Task<ServiceResponse<List<Product>>> GetProductByNameAsync(string productName);

    }
}
