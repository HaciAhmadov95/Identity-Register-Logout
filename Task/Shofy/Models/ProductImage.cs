namespace Shofy.Models
{
    public class ProductImage
    {
        public string Name { get; set; }
        public bool IsMain { get; set; } = false;
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
