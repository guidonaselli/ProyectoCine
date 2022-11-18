using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProyectoCine.Models;
using System.Reflection.Metadata;

namespace ProyectoCine.Controllers
{
    public class EntradaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Entrada>? entradas = null;

            using (CineContext context = new())
            {
                entradas = context.entradas.ToList();
            }

            //string titulo = "Entrada creada";
            //TempData["titulo"] = titulo;
            //HttpContext.Session.SetString("clave", titulo);
            return View(entradas);
        }

        //Vista de Entrada
        public IActionResult EntradaSd()
        {
            return View(nameof(Entrada));
        }


        //Vista de Create
        //VER SI HAY QUE HACER ALGO ASÍ PARA COMPRAR LA ENTRADA, esta va a mostrar el formulario?
        //GET muestra los datos, cuando envio datos de la pagina hacia el controlador hacemos un POST


        //lee el formulario de cliente, levanta la vista
        [HttpGet]
        public IActionResult Entrada()
        {
            //string? titulo = TempData["titulo"].ToString();
            //string? valor = HttpContext.Session.GetString("clave");
            //ViewBag.valor = valor;
            return View(nameof(Entrada));
        }

        [HttpGet]
        public IActionResult PeliBlackPanther()
        {
            
            return View(nameof(PeliBlackPanther));
        }

        //recibe y crea un cliente
        [HttpPost]
        public IActionResult Create(Entrada entrada)
        {
            using (CineContext context = new())
            {
                context.entradas.Add(entrada); //guarda de forma lógica la entrada. Se fija si puede guardar la entrada en la base de datos.
                context.SaveChanges(); //graba los cambios
            }
            return View(nameof(Entrada));
        }

        [HttpPost]
        public IActionResult Update(int id, Entrada entrada)
        {
            //Actualizar los datos de la entrada segun un id
            using (CineContext context = new())
            {
                if (id != entrada.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    context.entradas.Update(entrada);
                    context.SaveChanges();
                }

                return RedirectToAction(nameof(Entrada));
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Elimina la entrada segun un id 
            using (CineContext context = new())
            {
                if (id != 0)
                {
                    Entrada? cliente = context.entradas.Find(id);
                    if (cliente != null)
                    {
                        context.entradas.Remove(cliente);
                        context.SaveChanges();
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
