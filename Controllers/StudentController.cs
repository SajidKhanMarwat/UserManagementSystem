using Microsoft.AspNetCore.Mvc;

namespace UserManagementSystem.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {

            return View();
        }

        public IActionResult Remove()
        {

            return View();
        }
    }
}
