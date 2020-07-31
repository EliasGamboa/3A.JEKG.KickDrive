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

namespace KickDrive.Pages
{
    public class SupervisionRegistradaModel : PageModel
    {
        
        private readonly AppDBContext _context;

        public SupervisionRegistradaModel(AppDBContext context)
        {
            _context = context;

        }



        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BuscarVehiculo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ProcesoRevisionss { get; set; }
        public string Supervisorss { get; set; }


        public IList<ProcesoRevision> ProcesoRevisions { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<int> genreQuery = from m in _context.ProcesoRevisions
                                         orderby m.Id
                                         select m.Id;

            var Emp = from m in _context.ProcesoRevisions
                      select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Emp = Emp.Where(s => s.Incidentes.Contains(SearchString));
            }

            BuscarVehiculo = new SelectList(await genreQuery.Distinct().ToListAsync());
            ProcesoRevisions = await Emp.Include(l => l.Supervisor).ToListAsync();
        }
    }
}
