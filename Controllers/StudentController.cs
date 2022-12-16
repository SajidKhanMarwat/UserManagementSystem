using UserManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Services;

namespace UserManagementSystem.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {

            List<StdModel> std = StudentAllData.ShowAll();

            return View(std);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StdModel stdObj)
        {
            Services.StudentAllData.Add(stdObj);
            return RedirectToAction("Index", stdObj);
        }
    }
}
