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
    public class EliminarSModel : PageModel
    {
        [BindProperty]
        public ProcesoRevision ProcesoRevision { get; set; }
        private readonly AppDBContext _context;
        public EliminarSModel(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ProcesoRevision = await _context.ProcesoRevisions.FindAsync(id);
            if (ProcesoRevision == null)
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
            ProcesoRevision = await _context.ProcesoRevisions.FindAsync(id);
            if (ProcesoRevision != null)
            {
                _context.ProcesoRevisions.Remove(ProcesoRevision);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}