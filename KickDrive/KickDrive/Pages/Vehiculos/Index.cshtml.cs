using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Service;

namespace KickDrive.Pages.Vehiculos
{
    public class IndexModel : PageModel
    {
        private readonly IRepository1<Vehiculo> repository1;
        public IEnumerable<Vehiculo> Vehiculos { get; private set; }
        public IndexModel(IRepository1<Vehiculo> repository1)
        {
            this.repository1 = repository1;
        }
        public IActionResult OnGet()
        {
            try
            {
                Vehiculos = repository1.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFound");
            }
        }
    }
}