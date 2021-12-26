using PortalGrup.Models.Customer.Abstract;
using PortalGrup.Models.Customer.Concrate.Type;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Models.Customer.Concrate
{
    public class StarbucksCustomer : IStarbucksCustomer
    {
        public List<DbCustomer> GetCustomers()
        {
            return Db.GetAll(CompanyEnum.Starbucks);
        }

        public async Task<Dictionary<bool, string>> InsertAsync(DbCustomer customer)
        {
            Dictionary<bool, string> result = new Dictionary<bool, string>();

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(customer.TC, customer.Ad, customer.Soyad, customer.DogumYili);

            if(response.Body.TCKimlikNoDogrulaResult)
            {
                Db.Add(customer);
                result.Add(true, "başarılı");
            }
            else
            {
                result.Add(false, "KPS err");
            }            
            
            return result;
        }
    }
}
