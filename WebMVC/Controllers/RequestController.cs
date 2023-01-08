using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class RequestController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }

        private static List<RequestViewModel> _requestViewModel = new List<RequestViewModel>()
        {
            new RequestViewModel(1,4,"PIC09", "RAM 9 Gb Intel core I3","Quality Assurance"),
            new RequestViewModel(2,6,"PIC56", "RAM 4 Gb Intel Atom I","BackEnd Developer"),
            new RequestViewModel(3,9,"PIC57", "RAM 32 Gb RYZEN 7 5800H3","Technical Writer"),
            new RequestViewModel(4,12,"PIC89", "RAM 9 Gb Intel core I3","Quality Assurance"),
            new RequestViewModel(5,9,"PIC05", "RAM 16 Gb Ryzen 5-5625U","FrontEnd Developer"),
            
        };

        public IActionResult List()
        {
            return View(_requestViewModel);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, IdAsset, PicId, SpecificationReq, Necessary")] RequestViewModel request)
        {
            _requestViewModel.Add(request);
            return Redirect("List");
        }

        public IActionResult Delete(int? id)
        {
            RequestViewModel request = _requestViewModel.Find(r => r.Id.Equals(id));
            _requestViewModel.Remove(request);
            return Redirect("/Request/List");
        }

        public IActionResult Details(int id)
        {
            RequestViewModel request = (
                from r in _requestViewModel
                where r.Id.Equals(id)
                select r
            ).SingleOrDefault(new RequestViewModel());
            return View(request);
        }

        public IActionResult Edit(int? id)
        {
            RequestViewModel request = _requestViewModel.Find(r=> r.Id.Equals(id));
            return View(request);
        }
        
        public IActionResult Update(int id,[Bind("Id, IdAsset, PicId, SpecificationReq, Necessary")]
            RequestViewModel request)
        {
            RequestViewModel requestPre= _requestViewModel.Find(a => a.Id.Equals(id));
            _requestViewModel.Remove(requestPre);
            _requestViewModel.Add(request);
            return Redirect("List");
        }
    }
}