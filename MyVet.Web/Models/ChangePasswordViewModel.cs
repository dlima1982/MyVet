using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Display(Name = "Passwprd Actual")]
        [Required(ErrorMessage = "El campo {0} Obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Debe contener entre {2} y {1} Caracteres.")]
        public string OldPassword { get; set; }

        [Display(Name = "Nuevo Password")]
        [Required(ErrorMessage = "El campo {0} Obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Debe contener entre {2} y {1} Caracteres.")]
        public string NewPassword { get; set; }

        [Display(Name = "Confirmar Password")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Debe contener entre {2} y {1} Caracteres.")]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}
