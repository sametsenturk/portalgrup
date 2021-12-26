using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortalGrup.Models;
using PortalGrup.Models.Customer.Abstract;
using PortalGrup.Models.Customer.Concrate.Type;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGrup.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortalCustomer _portalCustomer;
        private readonly IStarbucksCustomer _starbucksCustomer;

        public HomeController(IPortalCustomer portalCustomer, IStarbucksCustomer starbucksCustomer)
        {
            _portalCustomer = portalCustomer;
            _starbucksCustomer = starbucksCustomer;
        }

        public IActionResult List()
        {
            List<DbCustomer> result = new List<DbCustomer>();
            result.AddRange(_starbucksCustomer.GetCustomers());
            result.AddRange(_portalCustomer.GetCustomers());
            return View(result);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCustomerVM model)
        {
            var customer = new DbCustomer
            {
                Ad = model.Name,
                Company = model.Company,
                DogumYili = model.BirthYear,
                Soyad = model.Surname,
                TC = model.TC
            };

            if(model.Company == CompanyEnum.Starbucks)
            {
                var operation = _starbucksCustomer.InsertAsync(customer);
                ViewBag.msg = operation.Result.First().Value;
            }
            else if(model.Company == CompanyEnum.Portal)
            {
                var operation = _portalCustomer.InsertAsync(customer);
                ViewBag.msg = operation.Result.First().Value;
            }
            return View();
        }

    }
}
