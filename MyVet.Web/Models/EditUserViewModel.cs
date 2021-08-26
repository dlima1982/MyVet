using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        public string PhoneNumber { get; set; }

    }
}
