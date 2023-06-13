using E_CommerceWebApplication.Shared.Models;

namespace E_CommerceWebApplication.Client.Services.ProductService
{
    public interface IProductService
    {
        public ServiceResponse<DisplayedProducts> displayedProducts { get; set; }
        public ServiceResponse<List<string>> Words  { get; set; }
        public Task GetProducts(int pageNumber);
        public  Task GetProductsByCategory(string categoryName, int pageNumber);

        public Task SuggestedWords(string input);
        public Task Search(string input, int pageNumber);

    }
}
