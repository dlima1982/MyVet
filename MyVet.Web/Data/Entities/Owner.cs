using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="El {0} es obligatorio")]
        [MaxLength(15, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Documento")]
        public string Document { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(12, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Telefono Fijo")]
        public string FixedPhone { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(12, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Telefono Celular")]
        public string CellPhone { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "el {0} solo puede contener un maximo de {1} caracteres")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        //public string FullName 
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }

        //}

        [Display(Name = "Nombre De Propiestario")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Nombre con Identificacion")]
        public string FullNameWithDocument => $"{FirstName} {LastName}";
    }
}
