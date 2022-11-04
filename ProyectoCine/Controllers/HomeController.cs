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
            string nombre = ", GOODDD";
            string alumnos = "BRURRTALL";
            //  ViewData["nombre"] = nombre;
            //  ViewBag.alumnos = alumnos;

            List<string> personas = new();
            personas.Add(nombre);
            personas.Add(alumnos);
            //personas[0] = nombre;
            //personas[1] = alumnos;



            List<string> participantes = new();
            participantes.Add("Juan");
            participantes.Add("Orca");
            participantes.Add("Juan");
            participantes.Add("Roar");
            participantes.Add("Juan");
            participantes.Add("Asuu");

            ViewBag.nombre = "Juan";

            //agregarPelicula("Black Adam", "Black Adam es una película estadounidense de superhéroes basada en el personaje homónimo de DC Comics. Producida por DC Films, New Line Cinema, Seven Bucks Productions y FlynnPictureCo., y distribuida por Warner Bros. Pictures, pretende ser una derivación de ¡Shazam!");

            return View(nameof(Index));

        }
        public IActionResult Boleteria()
        {
            return RedirectToAction(nameof(CargarPeliculas));

        }

        public IActionResult Contacto()
        {
            return View(nameof(Contacto));

        }

        public IActionResult Ubicacion()
        {
            return View(nameof(Ubicacion));

        }

        public IActionResult CargarPeliculas()
        {
            List<Pelicula> peliculas;

            using (CineContext context = new CineContext())
            {
                peliculas = context.peliculas.ToList();


            }

            return View(nameof(Boleteria), peliculas);
        }

        public void agregarPelicula(string s1, string s2)
        {
            using (CineContext context = new())
            {
                context.peliculas.Add(new Pelicula(s1, s2));
                context.SaveChanges();
            }
        }

        public IActionResult Create(Pelicula pelicula)
        {
            using (CineContext context = new())
            {

                context.peliculas.Add(pelicula);
                context.peliculas.Add(new Pelicula("dasdsa","asdas"));
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));

        }
    }
}