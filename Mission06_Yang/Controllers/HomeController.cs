using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Yang.Models;

namespace Mission06_Yang.Controllers
{
    public class HomeController : Controller
    {
        private Mission6Context _context;
        public HomeController(Mission6Context SomeName)
        {
            _context = SomeName;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormPage(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation",response);
        }


        public IActionResult GettoKnowJoel()
        {
            
            return View();
        }

    }
}
