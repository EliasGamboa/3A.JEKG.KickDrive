using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Vehiculo : BaseEntity
    {
       
        public string NombreProp { get; set; }
        public string Automovil { get; set; }
        public string Modelo { get; set; }
        public string FechaExpedicion { get; set; }
        public string Vigencia { get; set; }
        public string NumeroMotor { get; set; }
        public string Combustible { get; set; }
        public string Ancho { get; set; }
        public string Largo { get; set; }
        public string Alto { get; set; }
        public string Uso { get; set; }
        public string Placas { get; set; }
        public string ItemModelNumber { get; set; }
        public string PhotoBusiness { get; set; }
        public int NumeroCamion { get; set; }

        [Display(Name = "Conducor")]
        [ForeignKey("Conductor")]
        public int? ConductorId { get; set; }
        public Conductor Conductor { get; set; }

    }
}
