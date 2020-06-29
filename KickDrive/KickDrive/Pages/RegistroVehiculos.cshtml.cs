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
    public class RegistroVehiculosModel : PageModel
    {
        private readonly IRepository1<Vehiculo> repository1;
        public IEnumerable<Vehiculo> Vehiculos { get; set; }

        public RegistroVehiculosModel(IRepository1<Vehiculo> repository1)
        {
            this.repository1 = repository1;
        }
        public void OnGet()
        {
            Vehiculos = repository1.GetAll();
        }
    }
}