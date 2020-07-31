using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using Service;

namespace KickDrive.Pages.Vehiculos
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;

        }



        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BuscarVehiculo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Vehiculoss { get; set; }
        public string Conductorss { get; set; }


        public IList<Vehiculo> Vehiculos { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<int> genreQuery = from m in _context.Vehiculos
                                         orderby m.Id
                                         select m.Id;

            var Emp = from m in _context.Vehiculos
                      select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Emp = Emp.Where(s => s.NumeroMotor.Contains(SearchString));
            }

            BuscarVehiculo = new SelectList(await genreQuery.Distinct().ToListAsync());
            Vehiculos = await Emp.Include(l => l.Conductor).ToListAsync();
        }
    }
}
