using Microsoft.AspNetCore.Mvc;

namespace TechBoxtoUnbox.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
