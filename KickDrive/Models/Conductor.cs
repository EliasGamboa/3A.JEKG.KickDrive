﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Conductor : BaseEntity
    {
       
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string INE { get; set; }
        public string ComprobanteDomicilio { get; set; }
        public string LicenciaConducir { get; set; }
        public string SeguroSocial { get; set; }
        public string Fotografia { get; set; }

       
        
    }
}
