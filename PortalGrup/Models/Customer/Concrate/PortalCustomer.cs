using PortalGrup.Models.Customer.Abstract;
using PortalGrup.Models.Customer.Concrate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer.Concrate
{
    public class PortalCustomer : IPortalCustomer
    {
        public List<DbCustomer> GetCustomers()
        {
            return Db.GetAll(CompanyEnum.Portal);
        }

        public async Task<Dictionary<bool, string>> InsertAsync(DbCustomer customer)
        {
            Dictionary<bool, string> result = new Dictionary<bool, string>();
            Db.Add(customer);
            result.Add(true, "başarılı");
            return result;
        }
    }
}
