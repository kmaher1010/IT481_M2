using Microsoft.EntityFrameworkCore;

namespace IT481_M2.DataLayer {
    internal class NorthwindContext : DbContext {
        public NorthwindContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer>(entity => {
                entity.HasKey(e => e.CustomerID);
            });
        }

    }

    public class Customer {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
    }
}



