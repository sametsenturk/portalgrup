using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer.Concrate.Type
{
    public class DbCustomer
    {
        public long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public CompanyEnum Company { get; set; }
    }
}
