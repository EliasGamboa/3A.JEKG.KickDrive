using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Service;

namespace KickDrive.Pages
{
    public class VehiculosRegistradosModel : PageModel
    {
        private readonly IRepository1 repository1;
        public IEnumerable<Vehiculo> Vehiculos { get; set; }

        public VehiculosRegistradosModel(IRepository1 repository1)
        {
            this.repository1 = repository1;
        }
        public void OnGet()
        {
            Vehiculos = repository1.getall();
        }
    }
}