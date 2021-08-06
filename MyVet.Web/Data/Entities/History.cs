using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class History
    {

        public int Id { get; set; }


        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El {0} no puede tener una cantidad superior a {1} Caracteres")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name ="Comentarios Adicionales")]
        public string Remarks { get; set; }


        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime DateLocal => Date.ToLocalTime();
    }

}

