using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Mvc.Controllers
{
    public class EmployeeController : Controller
    { 
        // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        } 
        
    }
}
