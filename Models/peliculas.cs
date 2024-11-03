using System.ComponentModel.DataAnnotations;

namespace Cinefilos.Models
{
    public class PeliculasCinefilos
    {
        [Key]
        public int idpeliculas { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Sinopsis { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }

    }
}


