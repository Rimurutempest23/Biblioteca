using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaMVC.Models
{
    public class LibroViewModel
    {

        public int id { get; set; }

        [Required(ErrorMessage = "El campo 'Titulo' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Titulo' no puede tener más de 100 caracteres.")]
        [Display(Name = "Titulo")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "El campo 'Autor' es obligatorio.")]
        [Display(Name = "Autor")]
        public string Author { get; set; } = "";

        [Required(ErrorMessage = "El campo 'Fecha de Publicacion' es obligatorio.")]
        [Display(Name = "Fecha de Publicacion")]
        [Range(1900, 2027, ErrorMessage = "El año de publicación debe estar entre 1900 y 2027.")]
        public int Release { get; set; }

        [Required(ErrorMessage = "El campo 'Categoria' es obligatorio.")]
        [Display(Name = "Categoria")]
        public string Category { get; set; } = "";
    }
}
