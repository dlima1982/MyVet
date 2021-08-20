using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using MyVet.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            var list = _dataContext.PetTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.id}"

            }).OrderBy(pt => pt.Text)
             .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un Tipo de Mascota..]",
                Value = "0"
            });



            return list;

        }

    }
}
