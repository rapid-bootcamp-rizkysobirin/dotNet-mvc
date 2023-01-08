using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class AdminController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }

        private static List<AdminViewModel> _adminViewModels = new List<AdminViewModel>()
        {
            new AdminViewModel(1, "Joko", 3, "Jok@mail.id", 6),
            new AdminViewModel(2, "Sudarto", 2, "Dar@mail.id", 2),
            new AdminViewModel(3, "Sukmono", 2, "Suk@mail.id", 9),
            new AdminViewModel(4, "Warno", 1, "War@mail.id", 2),
            new AdminViewModel(5, "Sudano", 3, "Dano@mail.id", 5),
            new AdminViewModel(6, "Hendro", 3, "Hendr@mail.id", 6)
            
        };

        public IActionResult List()
        {
            return View(_adminViewModels);
        }
        
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id, Name, Role, Email, IdAudit")] AdminViewModel admin)
        {
            _adminViewModels.Add(admin);
            return Redirect("List");
        }
        
        public IActionResult Details(int id)
        {
            AdminViewModel admin = (
                from a in _adminViewModels
                where a.Id.Equals(id)
                select a).SingleOrDefault(new AdminViewModel());
            return View(admin);
        }
        
        public IActionResult Delete(int? id)
        {
            AdminViewModel admin = _adminViewModels.Find(a => a.Id.Equals(id));
            _adminViewModels.Remove(admin);
            return Redirect("/Admin/List");
        }
    }
}