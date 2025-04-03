using efcore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.ApplicationContext;

namespace _.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ApplicationContext _Context;
        public EmployeController(ApplicationContext Context){
            _Context=Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employe employe)
        {
            if (ModelState.IsValid)
            {
                _Context.employes.Add(employe);
                Console.WriteLine ("id"+employe.eid+"Name"+employe.name+" Salary"+employe.salary);   
                _Context.SaveChanges();
                return Content("Thank You!");

            }
            return View(employe);
        }
        public IActionResult Delete(int id)
        {
            var employe = _Context.employes.Find(id);
            _Context.employes.Remove(employe);
            _Context.SaveChanges();
            return Content("User Deleted");
        }

        [HttpPost]
        public IActionResult Update(Employe employe)
        {
            if (ModelState.IsValid)
            {
                _Context.employes.Update(employe);
                Console.WriteLine ("id"+employe.eid+"Name"+employe.name+" Salary"+employe.salary);   
                _Context.SaveChanges();
                return Content("Thank You!");

            }
            return View(employe);
        }

        public IActionResult Display(int id)
        {
            var employe = _Context.employes.Find(id);
            return Content("id"+employe.eid+"Name"+employe.name+" Salary"+employe.salary);
        }
    }
}
