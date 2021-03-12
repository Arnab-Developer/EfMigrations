using EfMigrations.WebApp.Data;
using EfMigrations.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EfMigrations.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstitutionContext _institutionContext;

        public HomeController(InstitutionContext institutionContext)
        {
            _institutionContext = institutionContext;
        }

        public IActionResult Index()
        {
            List<Student> students = _institutionContext.Students!.OrderBy(s => s.Id).ToList();
            return View("Index", students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
