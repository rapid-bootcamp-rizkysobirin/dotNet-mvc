using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class AssetController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // ini isi yg akan ditampilkan
        private static List<AssetViewModel> _assetViewModels = new List<AssetViewModel>()
        {
            new AssetViewModel(1, "Laptop Asus", "RAM 9 Gb Intel core I3", "ASS201", 2020),
            new AssetViewModel(2, "Laptop Lenovo", "RAM 4 Gb Intel Atom I9", "LVV930", 2022),
            new AssetViewModel(3, "Laptop MSI", "RAM 16 Gb Ryzen 5-5625U", "MSS490", 2019),
            new AssetViewModel(4, "Laptop Toshiba", "RAM 32 Gb RYZEN 7 5800H", "ALL990", 2021),
        };

        public IActionResult Assets() //manampilkan list asset
        {
            return View(_assetViewModels);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, Name, Specification, SerialNumber, PurchaseYear")] AssetViewModel asset)
        {
            Console.WriteLine(asset);
            _assetViewModels.Add(asset);
            Console.WriteLine(asset);
            return Redirect("Assets");
        }

        public IActionResult Delete(int? id)
        {
            AssetViewModel asset = _assetViewModels.Find(x => x.Id.Equals(id));
            _assetViewModels.Remove(asset);
            return Redirect("/Asset/Assets");
        }

        public IActionResult Details(int id)
        {
            AssetViewModel asset = (
                from a in _assetViewModels
                where a.Id.Equals(id)
                select a
            ).SingleOrDefault(new AssetViewModel());
            return View(asset);
        }

        public IActionResult Edit(int? id) // ini tampilan edit
        {
            // AssetViewModel asset = _assetViewModels.Find(a => a.Id.Equals(id));
            // return View(asset);

            AssetViewModel asset = _assetViewModels.Find(a => a.Id.Equals(id));
            return View(asset);
        }

        [HttpPost]
        public IActionResult Update(int id,
            [Bind("Id, Name, Specification, SerialNumber, PurchaseYear")]
            AssetViewModel asset)
        {
            AssetViewModel assetOld = _assetViewModels.Find(a => a.Id.Equals(id));
            _assetViewModels.Remove(assetOld);
            _assetViewModels.Add(asset);
            return Redirect("Assets");
        }

    }
}