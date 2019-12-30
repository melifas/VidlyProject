using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyProject.Models;

namespace VidlyProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCustomers()
        {
            using (VidlyEntities _contex = new VidlyEntities())
            {                
                List<Customer> customers = _contex.Customers.ToList();                
                return View(customers);

            }
        }
    }
}