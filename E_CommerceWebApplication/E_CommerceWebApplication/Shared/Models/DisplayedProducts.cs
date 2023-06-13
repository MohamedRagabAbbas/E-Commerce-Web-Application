
namespace E_CommerceWebApplication.Shared.Models
{
    public class DisplayedProducts
    {
        public int pageNumber { get; set; }
        public int numberOfPages { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
    }
}
