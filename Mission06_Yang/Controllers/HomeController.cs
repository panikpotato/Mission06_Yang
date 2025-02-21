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
            ViewBag.Categories =_context.Categories;

            return View("FormPage", new Movies());
        }
        [HttpPost]
        public IActionResult FormPage(Movies response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                ViewBag.Categories = _context.Categories;

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories;
                return View(response);
            }
        }


        public IActionResult GettoKnowJoel()
        {

            return View();
        }
        public IActionResult Waitlist()
        {
            var applications = _context.Movies
                .Where(x => x.Edited == true)
                .OrderBy(x => x.Year).ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {   var recordToEdit = _context.Movies
                .Single(x => x.MovieId ==id);
            ViewBag.Categories = _context.Categories;


            return View("FormPage", recordToEdit );
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("Waitlist");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movies application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();
            return RedirectToAction("Waitlist");
        }
    }
}
