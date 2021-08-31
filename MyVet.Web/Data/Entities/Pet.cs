using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener una cantidad superior a {1} Caracteres")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener una cantidad superior a {1} Caracteres")]       
        public string Race { get; set; }

        

        [Display(Name = "Fecha Nacimiento")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        [Display(Name = "Comentarios Adicionales")]
        public string Remarks { get; set; }


        [Display(Name = "Fecha Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();


        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://petsrus.azurewebsites.net{ImageUrl.Substring(1)}";


        public PetType PetType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<History> Histories { get; set; }



        public ICollection<Agenda> Agendas{ get; set; }
    }
}
