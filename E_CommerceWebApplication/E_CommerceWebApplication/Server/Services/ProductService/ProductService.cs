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



        public async Task<ServiceResponse<List<string>>> SuggestedWords(string input)
        {
            var prodcuts = await dbContext.Products.Where(p => p.ProductName.ToLower().Contains(input.ToLower()) || p.ProductDescription.ToLower().Contains(input.ToLower())).ToListAsync();
            if (prodcuts == null)
            {
                return null;
            }
            else
            {
                List<string> suggestedWords = new List<string>();
                foreach (var product in prodcuts)
                {
                    if(product.ProductName!=null)
                    {
                        if (product.ProductName.Contains(input))
                        {
                            List<string> words = (product.ProductName).Split().ToList();
                            foreach (var word in words)
                            {
                                if(word.Contains(input))
                                {
                                    suggestedWords.Add(word);
                                }
                            }
                        }
                    }
                    if (product.ProductDescription != null)
                    {
                        if (product.ProductDescription.Contains(input))
                        {
                            List<string> words = (product.ProductDescription).Split().ToList();
                            foreach (var word in words)
                            {
                                if (word.Contains(input))
                                {
                                    suggestedWords.Add(word);
                                }
                            }
                        }
                    }

                }
                
                return new ServiceResponse<List<string>>() { Data = suggestedWords }; 
            }
        }

        public async Task<ServiceResponse<DisplayedProducts>> Search(string input,int pgaeNumber)
        {

            int _numberOfProducts = (await dbContext.Products.Where(p => p.ProductName.ToLower().Contains(input.ToLower())|| p.ProductDescription.ToLower().Contains(input.ToLower())).ToListAsync()).Count;
            int _numberOfPages = (int)Math.Ceiling(_numberOfProducts / 6.0);
            var prodcuts = await dbContext.Products.Where(p => p.ProductName.ToLower().Contains(input.ToLower()) || p.ProductDescription.ToLower().Contains(input.ToLower())).Skip((pgaeNumber - 1) * 6).Take(6).ToListAsync();
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

    }
}
