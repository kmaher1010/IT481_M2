using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IT481_M2.DataLayer {
    public interface INorthwindRepository {
        long GetCustomerCount();
        List<string> GetCustomerNames();
    }
    internal class NorthwindRepository : INorthwindRepository {
        private NorthwindContext _context { get; set; }
        public NorthwindRepository( string connectionString ) {
            var optionsBuilder = new DbContextOptionsBuilder<NorthwindContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new NorthwindContext(optionsBuilder.Options);
        }

        public long GetCustomerCount() {
            return _context.Customers.Count();
        }

        public List<string> GetCustomerNames() {
            var customers = (from c in _context.Customers
                             select c.ContactName).ToList();

           var lastNames = customers.Select(c => c.Split(" ").Last()).ToList();
           return lastNames;
        }
    }
}
