using PortalGrup.Models.Customer.Concrate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models
{
    public class AddCustomerVM
    {
        public long TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public CompanyEnum Company { get; set; }
    }
}
