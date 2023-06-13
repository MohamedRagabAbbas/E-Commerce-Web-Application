using E_CommerceWebApplication.Server.Services.ProductService;
using E_CommerceWebApplication.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        
        [HttpGet("Page/{pgaeNumber}")]
        public async Task<ActionResult<ServiceResponse<DisplayedProducts>>> GetProducts(int pgaeNumber)
        {
            var response = await _productService.GetProductsAsync(pgaeNumber);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int Id)
        {
            var response = await _productService.GetProductByIdAsync( Id);
            return Ok(response);
        }

        [HttpGet("category/{categoryName}/{pageNumber}")]
        public async Task<ActionResult<ServiceResponse<DisplayedProducts>>> GetProductByCategory(string categoryName, int pageNumber)
        {
            var response = await _productService.GetProductsByCategoryAsync(categoryName, pageNumber);
            return Ok(response);
        }

        [HttpGet("productName/{name}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductByName(string name)
        {
            var response = await _productService.GetProductByNameAsync(name);
            return Ok(response);
        }

        [HttpGet("suggested/{input}")]
        public async Task<ActionResult<ServiceResponse<List<string>>>> SuggestedWords(string input)
        {
            var response = await _productService.SuggestedWords(input);
            return Ok(response);
        }

        [HttpGet("search/{input}/{pageNumber}")]
        public async Task<ActionResult<ServiceResponse<DisplayedProducts>>> Search(string input, int pageNumber)
        {
            var response = await _productService.Search(input, pageNumber);
            return Ok(response);
        }


    }



}






    

