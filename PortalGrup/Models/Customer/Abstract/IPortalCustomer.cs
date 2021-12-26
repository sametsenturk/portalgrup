using PortalGrup.Models.Customer.Concrate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer.Abstract
{
    public interface IPortalCustomer: ICustomer<DbCustomer>
    {
    }
}
