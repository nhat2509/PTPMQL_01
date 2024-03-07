using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace Mvc.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Index (Person ps){
            string str = "Xin chào:" + ps.PersonId + "-" +ps.FullName + "-" + ps.Address;
            ViewBag.ThongTin=str;
            return View();


        }
    }
}
