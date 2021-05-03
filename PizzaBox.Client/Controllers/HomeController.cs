using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing.UnitofWork;
using System.Diagnostics;

namespace PizzaBox.Client.Controllers
{
    public class HomeController : Controller
    {

        private readonly UnitofWork _unitofwork;

        public HomeController(UnitofWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public IActionResult Index()
        {
            var ordermvc = new OrderMVC();
            ordermvc.Load(_unitofwork);
            return View("index", ordermvc);
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
