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
    public class EditarSModel : PageModel
    {
        private readonly AppDBContext _context;

        public EditarSModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProcesoRevision ProcesoRevision { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProcesoRevision = await _context.ProcesoRevisions
                .Include(e => e.Supervisor).FirstOrDefaultAsync(m => m.Id == id);


            if (ProcesoRevision == null)
            {
                return NotFound();
            }

            ViewData["Id"] = new SelectList(_context.Vehiculos, "Id", "Nombre");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProcesoRevision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(ProcesoRevision.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Index");
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.Id == id);
        }
    }
}