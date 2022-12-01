using System.ComponentModel.DataAnnotations;

namespace ProyectoCine.Models
{
    public class Entrada
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Sala { get; set; }

        [Required]
        public String Fila { get; set; }

        [Required]
        public int Asiento { get; set; }

        [Required]
        public string NombreYApellido { get; set; }

        [Required]
        public string Horario { get; set; }

        [Required]
        public string NombrePelicula { get; set; }

    }
}
