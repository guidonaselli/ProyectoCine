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

        //Vista de Entrada, muestra el formulario.
        [HttpGet]
        public IActionResult EntradaSd()
        {
            return View(nameof(Entrada));
        }


        //Vista de Create
        //VER SI HAY QUE HACER ALGO ASÍ PARA COMPRAR LA ENTRADA, esta va a mostrar el formulario?
        //GET muestra los datos, cuando envio datos de la pagina hacia el controlador hacemos un POST


        //muestra el formulario de comprar la entrada, levanta la vista
        [HttpGet]
        public IActionResult BuyTickets() //ESTA ACCION ES EL QUE MUESTRA LA VISTA DEL FORMULARIO. Lo que abre el boton comprar entrada
        {
            //string? titulo = TempData["titulo"].ToString();
            //string? valor = HttpContext.Session.GetString("clave");
            //ViewBag.valor = valor;
            return View(nameof(BuyTickets));
        }
        //recibe y crea un entrada
        [HttpPost]
        public IActionResult Create(Entrada entrada) //desde la pantalla de BuyTickets, llena los datos de la entrada y lo envía al servidor
        {
            using (CineContext context = new()) //el using arma un ámbito donde el objeto declarado, en este caso context,va a estar vivo. Vive en el scope del using, para liberar memoria  
            {
                context.entradas.Add(entrada); //guarda de forma lógica la entrada. Se fija si puede guardar la entrada en la base de datos.
                context.SaveChanges(); //graba o impacta los cambios
            }
            return RedirectToAction(nameof(Index));
            
          }

        [HttpGet]
        public IActionResult PeliBlackPanther()
        {
            return View(nameof(PeliBlackPanther));

        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            using (CineContext context = new())
            {

                //var buscamosCliente  = (from c in context.Clientes where c.Id == Id select c);
                //Cliente? cliente = buscamosCliente.FirstOrDefault();

                Entrada? entrada = context.entradas.Find(Id);


                if (entrada != null)
                {
                    return View(entrada);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
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
                return RedirectToAction(nameof(Index));
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
                    Entrada? entrada = context.entradas.Find(id);
                    if (entrada != null)
                    {
                        context.entradas.Remove(entrada);
                        context.SaveChanges();
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
