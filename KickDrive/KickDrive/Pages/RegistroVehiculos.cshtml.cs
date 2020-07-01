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
        
        public IRepository1<Vehiculo> Repository1 { get; }
        public RegistroVehiculosModel(IRepository1<Vehiculo> repository1)
        {
            Repository1 = repository1;
        }
        [BindProperty]
        public Vehiculo Vehiculo { get; set; }
    }
}