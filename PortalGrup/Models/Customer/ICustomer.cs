using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer
{
    public interface ICustomer<T>
    {
        Task<Dictionary<bool, string>> InsertAsync(T customer);
        List<T> GetCustomers();
    }
}
