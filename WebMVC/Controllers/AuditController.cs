using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class AuditController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // ini isi yg akan ditampilkan
        private static List<AuditViewModel> _auditViewModels = new List<AuditViewModel>()
        {
            new AuditViewModel(1, 4, true, false,true, "dead pixel", "Pengecekan"),
            new AuditViewModel(2, 7, false, false,false, "cipset terbakar","Proses"),
            new AuditViewModel(3, 8, true, false,true, "baterai bocor", "Perbaikan"),
            new AuditViewModel(4, 2, true, true, true, "IC charge rusak", "Proses"),
        };

        public IActionResult List() //manampilkan list Audit
        {
            return View(_auditViewModels);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, IdAsset, AntiVirus, WindowsLicense, OfficeLicense, Condition, Validation")] AuditViewModel audit)
        {
            _auditViewModels.Add(audit);
            return Redirect("List");
        }

        public IActionResult Delete(int? id)
        {
            AuditViewModel audit = _auditViewModels.Find(x => x.Id.Equals(id));
            _auditViewModels.Remove(audit);
            return Redirect("/Audit/List");
        }

        public IActionResult Details(int id)
        {
            AuditViewModel audit = (
                from a in _auditViewModels
                where a.Id.Equals(id)
                select a
            ).SingleOrDefault(new AuditViewModel());
            return View(audit);
        }
        
        public IActionResult Edit(int? id) // ini tampilan edit
        {
            AuditViewModel audit = _auditViewModels.Find(a => a.Id.Equals(id));
            return View(audit);
        }
        
        [HttpPost]
        public IActionResult Update(int id,
            [Bind("Id, IdAsset, AntiVirus, WindowsLicense, OfficeLicense, Condition, Validation")]
            AuditViewModel audit)
        {
            AuditViewModel audit0 = _auditViewModels.Find(a => a.Id.Equals(id));
            _auditViewModels.Remove(audit0);
            _auditViewModels.Add(audit);
            return Redirect("List");
        }
    }
}