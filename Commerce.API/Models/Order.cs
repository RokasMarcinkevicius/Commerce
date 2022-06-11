namespace Commerce.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Client Client { get; set; }

        public Order(Product product, Client client)
        {
            Product = product;
            Client = client;
        }
    }
}
