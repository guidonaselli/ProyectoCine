using Microsoft.AspNetCore.Mvc;
using ProyectoCine.Models;
using System.Diagnostics;

namespace ProyectoCine.Controllers
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
            return RedirectToAction(nameof(CargarPeliculas));

        }

        public IActionResult CargarPeliculas()
        {
            List<Pelicula> peliculas;

            using (CineContext context = new CineContext())
            {
                peliculas = context.peliculas.ToList();
            }

            return View(nameof(Index), peliculas);
        }
    }
}