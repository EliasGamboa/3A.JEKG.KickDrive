using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Service;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;


namespace KickDrive.Pages.Vehiculos
{
    public class IndexModel : PageModel

    {
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IRepository1<Vehiculo> repository1;
        public IEnumerable<Vehiculo> Vehiculos { get; private set; }
        [Obsolete]

        public IndexModel(IRepository1<Vehiculo> repository1, IHostingEnvironment hostingEnvironment)
        {
            this.repository1 = repository1;
            _hostingEnvironment = hostingEnvironment;
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
        [Obsolete]
        public IActionResult OnPostVehiculos(string submit)
        {

            HtmlToPdfConverter converter = new HtmlToPdfConverter();
            WebKitConverterSettings settings = new WebKitConverterSettings();
            settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
            converter.ConverterSettings = settings;
            PdfDocument document = converter.Convert("https://localhost:44358/vehiculos");
            MemoryStream ms = new MemoryStream();
            document.Save(ms);
            document.Close(true);
            ms.Position = 0;
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
            fileStreamResult.FileDownloadName = "Reporte.pdf";
            return fileStreamResult;
        }
    }
}