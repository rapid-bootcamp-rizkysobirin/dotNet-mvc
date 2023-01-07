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
        
        private static List<ProductViewModel> _productViewModels = new List<ProductViewModel>()
        {
            new ProductViewModel(1, "Kapal", "Transportasi", 12000),
            new ProductViewModel(2, "Naga", "Hewan", 6000),
            new ProductViewModel(3, "Mie", "Makanan", 8000),
            new ProductViewModel(3, "Bensin", "Bahan Bakar", 10000),
        };


        public IActionResult List()
        {
        //     List<ProductViewModel> productlist = new List<ProductViewModel>()
        //     {
        //         new ProductViewModel(1, "Kapal", "Transportasi", 12000),
        //         new ProductViewModel(2, "Naga", "Hewan", 6000),
        //         new ProductViewModel(3, "Mie", "Makanan", 8000),
        //         new ProductViewModel(3, "Bensin", "Bahan Bakar", 10000),
        //
        //     };
            // ini pas masih statis
            // return View(productlist);
            return View(_productViewModels);//CRUD diganti gini
        }
        
        

        [HttpPost]
        public IActionResult Save([Bind("Id, Name, Category, Price")] ProductViewModel product)
        {
            _productViewModels.Add(product);
            return Redirect("List");
        }

        public IActionResult Edit(int? id)
        {
            //find menggunakan lambda
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }
        
        [HttpPost]
        public IActionResult Update(int id, [Bind("id", "Name", "Category", "Price")] ProductViewModel product)
        {
            //untuk menghapus data yg lama
            ProductViewModel productOld = _productViewModels.Find(x => x.Id.Equals(id));
            _productViewModels.Remove(productOld);
            
            //untuk input data baru
            _productViewModels.Add(product);
            return Redirect("List");

        }
        
        // public IActionResult Details()
        public IActionResult Details(int id)// menampilkan berdasar Id
        {
            // ProductViewModel product = new ProductViewModel(1, "Kapal", "Transportasi", 12000);
            // find dengan linq
            ProductViewModel product = (
                from p in  _productViewModels 
                where p.Id.Equals(id) 
                select  p
            ).SingleOrDefault(new ProductViewModel());
       
            return View(product);
        }

        public IActionResult Delete(int? id)
        {
            //stap kek gini
            // 1. find data 
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));
            // 2. remove from list
            _productViewModels.Remove(product);
            
            return Redirect("List");
        }
        
    }
}