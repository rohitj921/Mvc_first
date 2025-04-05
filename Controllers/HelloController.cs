using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MVC_First.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(int id=1, string name = "user")
        {
            ViewData["message"] = $"Hello {name}";
            ViewData["id"] = id;
            ViewData["name"] = name;
            return View();
        }
        public string Employee(int id ,string name="user")
        {

            return HtmlEncoder.Default.Encode($"Welcome {name} with employee code {id}");
        }
    }
}
