using E_CommerceWebApplication.Shared.Models;
using System.Net.Http.Json;

namespace E_CommerceWebApplication.Client.Services.ProductService
{
    public class ProductService: IProductService

    {


        public ServiceResponse<DisplayedProducts> displayedProducts { get; set; } = new ServiceResponse<DisplayedProducts>();
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task GetProducts(int pageNumber)
        {
           displayedProducts =  await _httpClient.GetFromJsonAsync<ServiceResponse<DisplayedProducts>>($"api/product/page/{pageNumber}");
        }

        public async Task GetProductsByCategory(string categoryName, int pageNumber)
        {
            displayedProducts = await _httpClient.GetFromJsonAsync<ServiceResponse<DisplayedProducts>>($"api/product/category/{categoryName}/{pageNumber}");
        }
    }
}
