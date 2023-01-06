using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            List<ProductViewModel> productlist = new List<ProductViewModel>()
            {
                new ProductViewModel(1, "Kapal", "Transportasi", 12000),
                new ProductViewModel(2, "Naga", "Hewan", 6000),
                new ProductViewModel(3, "Mie", "Makanan", 8000),
                new ProductViewModel(3, "Bensin", "Bahan Bakar", 10000),

            };
            return View(productlist);
        }

        public IActionResult Details()
        {
            ProductViewModel product = new ProductViewModel(1, "Kapal", "Transportasi", 12000);
            return View(product);
        }
    }
}