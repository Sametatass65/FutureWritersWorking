using Microsoft.AspNetCore.Mvc;
using TukcellKursWorking.Models;

namespace TukcellKursWorking.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRespository _productRespository;

        public ProductController()
        {
            _productRespository = new ProductRespository();
         
        }
        public IActionResult Index()
        {
            var products = _productRespository.GetAll();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            _productRespository.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Add(Product product)
        { 
            _productRespository.Add(product);
            return View();
        }
        public IActionResult Update(Product product)
        {
            _productRespository.Update(product);
            return View();
        }

    }
}
