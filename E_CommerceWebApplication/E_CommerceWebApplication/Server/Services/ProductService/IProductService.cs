using E_CommerceWebApplication.Server.Data;
using E_CommerceWebApplication.Shared.Models;

namespace E_CommerceWebApplication.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductByIdAsync(int Id);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryName);

    }
}
