using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer.Concrate.Type
{
    public static class Db
    {
        private static List<DbCustomer> Customers = new List<DbCustomer>();

        public static void Add(DbCustomer customer)
        {
            Customers.Add(customer);
        }

        public static List<DbCustomer> GetAll(CompanyEnum companyEnum)
        {
            return Customers.Where(x => x.Company == companyEnum).ToList();
        }
    }
}
