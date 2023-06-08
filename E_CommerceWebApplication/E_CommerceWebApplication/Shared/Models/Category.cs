using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebApplication.Shared.Models
{
    public  class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = String.Empty;
        public string CategoryDescription { get; set; } = String.Empty;
        public string CategoryImageUrl { get; set; } = String.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
