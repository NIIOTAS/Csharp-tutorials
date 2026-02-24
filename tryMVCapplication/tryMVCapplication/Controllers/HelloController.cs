using Microsoft.AspNetCore.Mvc;
using tryMVCapplication.Models;

namespace tryMVCapplication.Controllers
{
    public class HelloController : Controller
    {
            private static List<HelloViewModel> _helloViewModels = new List<HelloViewModel>();
        public IActionResult Index()
        {
            HelloViewModel heyya = new HelloViewModel();
       
            return View(_helloViewModels);
        }

            public IActionResult creator()
        {
            var cm = new HelloViewModel()
            {
                Name = "Creator",
                Age = 30
            };
            return View(cm);
        }

        public IActionResult createmember(HelloViewModel helloViewModel)
        {
            _helloViewModels.Add(helloViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

    }
}
