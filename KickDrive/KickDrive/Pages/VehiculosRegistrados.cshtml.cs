using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Service;

namespace KickDrive.Pages
{
    public class VehiculosRegistradosModel : PageModel
    {
        private readonly IRepository1<Vehiculo> repository1;
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
        [Obsolete]
        public VehiculosRegistradosModel(IRepository1<Vehiculo> repository1)
        {
            this.repository1 = repository1;
            
        }
        public void OnGet()
        {
            Vehiculos = repository1.GetAll();
        }
       
        }
    }
