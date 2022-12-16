using Microsoft.AspNetCore.Mvc;

namespace UserManagementSystem.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
