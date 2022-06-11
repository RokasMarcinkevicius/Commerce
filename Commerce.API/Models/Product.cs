namespace Commerce.API.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }

        public Product(string name, long price)
        {
            Name = name;
            Price = price;
        }
    }
}
