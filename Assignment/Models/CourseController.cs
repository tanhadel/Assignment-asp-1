namespace Assignment.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public int Hours { get; set; }
        public double Rating { get; set; }
        public int RatingsCount { get; set; }
    }
}

