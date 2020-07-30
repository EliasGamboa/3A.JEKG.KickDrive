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
    public class SupervisionRegistradaModel : PageModel
    {
        public IEnumerable<ProcesoRevision> ProcesoRevisions { get; set; }

        private readonly IRepository1<ProcesoRevision> repository1;
        public SupervisionRegistradaModel(IRepository1<ProcesoRevision> repository1)
        {
            this.repository1 = repository1;
        }
        public void OnGet()
        {
            ProcesoRevisions = repository1.GetAll();
        }
    }
}