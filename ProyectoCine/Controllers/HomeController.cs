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
            return View(nameof(Index));

        }
        //public IActionResult Boleteria()
        //{
        //    return RedirectToAction(nameof(CargarPeliculas));

        //}

        public IActionResult Contacto()
        {
            return View(nameof(Contacto));

        }

        public IActionResult Ubicacion()
        {
            return View(nameof(Ubicacion));

        }

        //      Opcion admin agrega/quita peliculas

        //public IActionResult CargarPeliculas()
        //{
        //    List<Pelicula> peliculas;

        //    using (CineContext context = new CineContext())
        //    {
        //        peliculas = context.peliculas.ToList();


        //    }

        //    return View(nameof(Boleteria), peliculas);
        //}

        //public void agregarPelicula(string s1, string s2)
        //{
        //    using (CineContext context = new())
        //    {
        //        context.peliculas.Add(new Pelicula(s1, s2));
        //        context.SaveChanges();
        //    }
        //}

        //public IActionResult Create(Pelicula pelicula)
        //{
        //    using (CineContext context = new())
        //    {

        //        context.peliculas.Add(pelicula);
        //        context.peliculas.Add(new Pelicula("dasdsa","asdas"));
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction(nameof(Index));

        //}
    }
}