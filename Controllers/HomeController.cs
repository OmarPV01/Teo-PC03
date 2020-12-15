using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Teo_PC03.Data;
using Teo_PC03.Models;

namespace Teo_PC03.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebAppContext _context;
        public HomeController(WebAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            DateTime fecha = DateTime.Today.AddDays(-7);
            var Formulario = _context.Formularios.Where(x => x.FecRes > fecha).ToList();
            return View(Formulario);
        }

        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Formulario f)
        {
            if(ModelState.IsValid){
                _context.Add(f);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(f);
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
