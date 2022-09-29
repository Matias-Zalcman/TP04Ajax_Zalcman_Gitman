using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP04Ajax_Zalcman_Gitman.Models;

namespace TP04Ajax_Zalcman_Gitman.Controllers
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
            ViewBag.ListaPaises = Info.ListarPaises();
            return View();
        }

        public IActionResult AgregarPais()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarPais(string nombre, string imgBandera, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos, string himno)
        {
            Info.AgregarPais(new Pais(nombre,imgBandera,poblacion,fechaIndependencia,atractivosTuristicos,himno));
            ViewBag.ListaPaises = Info.ListarPaises();
            return View("Index");
        }

        public Pais DetallePais(string Pais)
        {
            return Info.BuscarPais(Pais);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
