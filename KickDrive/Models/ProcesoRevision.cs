using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ProcesoRevision : BaseEntity
    {
        public string Ruta { get; set; }
        public string HorarioSupervision { get; set; }
        public string Incidentes { get; set; }
        public string InfoViajes { get; set; }

        [Display(Name = "Supervisor")]
        [ForeignKey("Supervisor")]
        public int? SupervisorId { get; set; }
        public Supervisor Supervisor { get; set; }
    }
}
