using UserManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Services;

namespace UserManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public StudentController() { 
        }

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
            StudentAllData.Add(stdObj);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(StdModel stdDelete)
        {
            StudentAllData.Delete(stdDelete);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update()
             
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(StdModel stdUpdate)
        {
            StudentAllData.Update(stdUpdate);
            return RedirectToAction("Index");
        }
    }
}
