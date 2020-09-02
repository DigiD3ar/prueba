using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using comentos.Models;

namespace comentos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Cuenta user)
        {
            if (user.isValid()) {
                return RedirectToAction("Opinion");

            }
            else {
                return RedirectToAction("Index");


            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Opinion(Comentario opinion)
        {
            
        }

        public IActionResult Felicidades()
        {
            if (opinion.isValid())
            {
                //mandar correo
                return View();

            }
            else
            {
                return RedirectToAction("Opinion");


            }
           
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
