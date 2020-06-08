using Models;
using System;
using System.Collections.Generic;

namespace Service
{
    public class MockVehiculoRepository1 :IRepository1
    {
        private List<Vehiculo> _vehiculos;
        public MockVehiculoRepository1()
        {
            _vehiculos = new List<Vehiculo>()
            {
                new Vehiculo {NombreProp = "Eduardo Alegre", Automovil = "Dodge Attitude", Modelo = "Sedan", NumeroMotor = "F9D55F8F789", placas = "EDU-A3L", uso = "Transporte Publico", largo = "4,245 mm", alto = "1,515 mm", ancho = "1,670 mm" }
            };
        }
        public IEnumerable<Vehiculo> getall()
        {
            return _vehiculos;
        }
    }

}
