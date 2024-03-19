using Microsoft.AspNetCore.Mvc;
using Future_Value.Models;
namespace Future_Value.Contollers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Faith";
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel futurevalue)
        {
            if(ModelState.IsValid)
            {
            ViewBag.FV = futurevalue.CalculateFutureValue();
            }
            else
            {
                ViewBag.Fv = 0;
            }
            return View(futurevalue);
        }
    }
}
