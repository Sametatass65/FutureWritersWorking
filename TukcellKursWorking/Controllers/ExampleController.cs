using Microsoft.AspNetCore.Mvc;
using TukcellKursWorking.Models;

namespace TukcellKursWorking.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.sayi = 1;
            ViewData["names"] = new List<String>() {"samet", "mehmet", "emre"};
            var products = new List<Product>()
            {
                new(){Id = 1, Name = "Samet" },
                new(){Id = 2, Name = "Berna" }
            };
            return View(products);
        }
        // Action Results
        public IActionResult Index2()
        {
            TempData["age"] = 32;
            return View();
        }
        public IActionResult ContentResult() 
        {
            return Content("denemem");
        }
        public IActionResult JSonResult()
        {
            return Json(new {id = 1, name = "samet" , age= 21 });
        }
        public IActionResult EmptyResult()
        {
            return EmptyResult();
        }
        public IActionResult RedirectToActionResult()
        {
            return RedirectToAction("Index","Example");
        }
    }
}
