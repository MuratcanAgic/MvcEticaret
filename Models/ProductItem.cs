namespace MvcEticaret.Models
{
    public class ProductItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StartCount { get; set; }
        public decimal OldPrice { get;set; }
        public decimal Price { get;set; }
        public string imageUrl { get; set; }
        public bool isSale { get; set; 
        }
    }
}
