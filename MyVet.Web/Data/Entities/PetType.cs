using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class PetType
    {
       
        public int id { get; set; }

        
        
       [Display(Name ="Tipo de Mascota")]
       [MaxLength(50, ErrorMessage ="El {0} no puede tener una cantidad superior a {1} Caracteres")]
       [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
