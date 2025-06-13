using System.ComponentModel.DataAnnotations;

namespace AgendaAPI.Models
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }

        [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
        public string Apellido { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public String Email {  get; set; }
    }
}
