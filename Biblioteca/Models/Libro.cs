using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Titulo { get; set; }

        [Required]
        [StringLength(50)]
        public string? Autor { get; set; }

        [Range(1000, 9999, ErrorMessage = "El año debe ser entre 1000 y 9999.")]
        public int AnioPublicacion { get; set; }

        [StringLength(30)]
        public string? Genero { get; set; }

        public bool Disponible { get; set; }
    }
}

