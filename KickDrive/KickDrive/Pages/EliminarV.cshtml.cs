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
    public class EliminarVModel : PageModel
    {
        [BindProperty]
        public Vehiculo Vehiculo { get; set; }
        private readonly AppDBContext _context;
        public EliminarVModel(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Vehiculo = await _context.Vehiculos.FindAsync(id);
            if (Vehiculo == null)
            {
                return RedirectToPage("./Index");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Vehiculo = await _context.Vehiculos.FindAsync(id);
            if (Vehiculo != null)
            {
                _context.Vehiculos.Remove(Vehiculo);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}