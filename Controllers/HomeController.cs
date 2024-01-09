using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            Form form = new Form();

            return View(form);
        }
        [HttpPost]
        public JsonResult Contact(Form form)
        {

            Console.WriteLine(form.ToString());
           
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}