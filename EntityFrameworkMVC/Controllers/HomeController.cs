using EntityFrameworkMVC.Models;
using EntityFrameworkMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
           // _logger = logger;
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
           IEnumerable<MemberShip> customers= _customerRepository.GetAllCustomerDetails();
            return View(customers);
        }

        [Route("Home/Details/{id}")]
        public IActionResult Details(int id)
        {
            var customer =_customerRepository.GetCustomerById(id);           
            return View(customer);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
