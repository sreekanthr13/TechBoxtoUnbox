using Microsoft.AspNetCore.Mvc;

namespace TechBoxtoUnbox.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            //Create api controller
            return View();
        }
    }
}
