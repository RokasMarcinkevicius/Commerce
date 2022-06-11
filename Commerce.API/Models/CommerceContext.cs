using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Commerce.API.Models
{
    public class CommerceContext : DbContext
    {
        public CommerceContext(DbContextOptions<CommerceContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

    }
}
