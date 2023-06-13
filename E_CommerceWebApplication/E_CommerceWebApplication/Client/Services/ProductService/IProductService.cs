using E_CommerceWebApplication.Shared.Models;

namespace E_CommerceWebApplication.Client.Services.ProductService
{
    public interface IProductService
    {
        public ServiceResponse<DisplayedProducts> displayedProducts { get; set; }
        public Task GetProducts(int pageNumber);
        public  Task GetProductsByCategory(string categoryName, int pageNumber);

    }
}
