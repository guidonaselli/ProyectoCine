using System.ComponentModel.DataAnnotations;

namespace ProyectoCine.Models
{

    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public List<string> Horarios = new List<String>();

        public Pelicula(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
    }
}
