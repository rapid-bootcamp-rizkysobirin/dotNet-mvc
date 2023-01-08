using Microsoft.AspNetCore.Mvc;

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
            new AuditViewModel(1, 4, true, false, "dead pixel", "Pengecekan"),
            new AuditViewModel(2, 7, false, false, "cipset terbakar","Proses"),
            new AuditViewModel(3, 8, true, false, "baterai bocor", "Perbaikan"),
            new AuditViewModel(4, 2, true, true, "IC charge rusak", "Proses"),
        };

        public IActionResult Audit() //manampilkan list asset
        {
            return View(_auditViewModels);
        }

        public IActionResult Add()
        {
            return View();
        }

    }
}