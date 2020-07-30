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
    public class RegistroSupervisionModel : PageModel
    {
        public IRepository1<ProcesoRevision> Repository1 { get; }
        public RegistroSupervisionModel(IRepository1<ProcesoRevision> repository1)
        {
            Repository1 = repository1;
        }
        [BindProperty]
        public ProcesoRevision ProcesoRevision { get; set; }
        public void OnPost()
        {
            var id = Repository1.Insert(ProcesoRevision);
        }
    }
}