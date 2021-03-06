using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class User : IdentityUser
    {

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

        [Display(Name = "Dirección")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Full Name")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
