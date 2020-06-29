using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IContainerRepository : IRepository1<Vehiculo>
    {
        public IEnumerable<Conductor> GetConductors();
    }
}
