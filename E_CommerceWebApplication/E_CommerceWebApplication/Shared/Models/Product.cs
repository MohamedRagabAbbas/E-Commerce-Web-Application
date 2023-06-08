using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebApplication.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public string ProductDescription { get; set; } = String.Empty;
        public string ProductImageUrl { get; set; } = String.Empty;
        public double ProductPrice { get; set; } = 0.0;
        public int ProductQuantity { get; set; }
        public int ProductCategoryId { get; set; }
        public Category? Category { get; set; } = null;
        public int ProductBrandId { get; set; }
        public  Brand? Brand { get; set; } = null;

        public string ProductColor { get; set; } = String.Empty;
        public string ProductSize { get; set; } = String.Empty;
        public string ProductGender { get; set; } = String.Empty;
        public string ProductMaterial { get; set; } = String.Empty;
        public double ProductDiscount { get; set; } = 0.0;
        
        public double ProductFinalPrice { get; }
        public bool? ProductAvailable { get; set; }
        public int? ProductRating { get; set; }

        public Product()
        {
            ProductFinalPrice = ProductPrice - (ProductPrice * ProductDiscount) / 100;
        }



    }
}
