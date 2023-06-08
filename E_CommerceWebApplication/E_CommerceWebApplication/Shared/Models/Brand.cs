using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebApplication.Shared.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = String.Empty;
        public string BrandDescription { get; set; } = String.Empty;
        public string BrandImageUrl { get; set; } = String.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
