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
    }
}
