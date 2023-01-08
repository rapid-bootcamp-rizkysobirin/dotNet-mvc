using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }
        private static List<EmployeeViewModel> _employeeViewModels = new List<EmployeeViewModel>()
        {
            new EmployeeViewModel(1, "Hary Riyanto","Admin", "HAr@MailAddress.id", "089765676543", "Jawa Selatan"),
            new EmployeeViewModel(2, "Sukaeri","Human Resource", "HAr@MailAddress.id", "084565896540", "Jawa Utara"),
            new EmployeeViewModel(3, "Maskuri","Admin", "MAs@MailAddress.id", "084765986532", "Kalimantan Selatan"),
            new EmployeeViewModel(4, "Masriyah","Developer", "Ritah@MailAddress.id", "081655676673", "Sumatera Selatan"),
            new EmployeeViewModel(5, "Odi Hartanyo","Manager", "Odi@MailAddress.id", "088065676543", "Jawa Barat Daya"),

        };

        public IActionResult List()
        {
            return View(_employeeViewModels);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id, Name, Position, Email, Number,Address")] EmployeeViewModel employee)
        {
            _employeeViewModels.Add(employee);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            EmployeeViewModel employee = (
                from e in _employeeViewModels
                where e.Id.Equals(id)
                select e).SingleOrDefault(new EmployeeViewModel());
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            EmployeeViewModel employee = _employeeViewModels.Find(e => e.Id.Equals(id));
            _employeeViewModels.Remove(employee);
            return Redirect("/Employee/List");
        }
        
        public IActionResult Edit(int? id) // ini tampilan edit
        {
            EmployeeViewModel employee = _employeeViewModels.Find(e => e.Id.Equals(id));
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(int id,
            [Bind("Id, Name, Position, Email, Number,Address")]
            EmployeeViewModel employee)
        {
            EmployeeViewModel employeePre = _employeeViewModels.Find(e => e.Id.Equals(id));
            _employeeViewModels.Remove(employeePre);
            _employeeViewModels.Add(employee);
            return Redirect("List");
        }
        
    }
}