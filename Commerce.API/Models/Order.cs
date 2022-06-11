using System.ComponentModel.DataAnnotations.Schema;

namespace Commerce.API.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Product? Product { get; set; }

        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
