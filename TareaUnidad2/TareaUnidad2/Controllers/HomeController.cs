using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using TareaUnidad2.Models;

namespace TareaUnidad2.Controllers
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

        public IActionResult Crear()
        {
            return View();
        }

        public IActionResult _ListaRecientes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Propiedades datos)
        {
            // Imprimir los datos del formulario
            ViewBag.Titulo = datos.Titulo;
            ViewBag.Descripcion = datos.Descripcion;
            ViewBag.FechaVencimiento = datos.FechaVencimiento;

            return View();
        }

        public IActionResult Editar()
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