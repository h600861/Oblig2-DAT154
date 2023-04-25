using Microsoft.AspNetCore.Mvc;
using WebAppOblig4.Models;
using WebAppOblig4.Services;

namespace WebAppOblig4.Controllers
{
    public class AccountController : Controller
    {
        private readonly H600861Context dx = new();
        private readonly ICustomerService customerService;

        public AccountController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Customer customer)
        {
            if(customerService.ValidCustomer(customer)) { 
             
                dx.Customers.Add(customer);
                dx.SaveChanges();
                return RedirectToAction("Home", "Privacy");
            }
            return View();
            }
        }
    }


