using IT481_M2.DataLayer;
using System.Collections.Generic;

namespace IT481_M2.BusinessLayer {
    public interface INorthwindService {
        long GetCustomerCount();
        List<string> GetCustomerNames();    
    }

    internal class NorthwindService: INorthwindService {
        private INorthwindRepository _northwindRepository { get; set; }
        public NorthwindService(  string connectionString ) {
            _northwindRepository = new NorthwindRepository(connectionString);
        }

        public long GetCustomerCount() {
            return _northwindRepository.GetCustomerCount();
        }

        public List<string> GetCustomerNames() {
            return _northwindRepository.GetCustomerNames();
        }
    }
}
