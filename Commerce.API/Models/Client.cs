namespace Commerce.API.Models
{
    public class Client
    {
        public long ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Order> ClientOrders { get; set; }

        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
