using Microsoft.AspNetCore.Mvc;

namespace MVC_First.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Oops! Page not found.";
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Internal server error occurred.";
                    break;
                default:
                    ViewBag.ErrorMessage = "An unexpected error occurred.";
                    break;
            }
            return View("CustomError");
        }
    }
}