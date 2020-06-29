using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ContainerRepository : SQLRepository<Vehiculo>, IContainerRepository
    {
        public ContainerRepository(AppDBContext context) : base(context) { }
        public IEnumerable<Conductor> GetConductors()
        {
            return context.Set<Conductor>().AsEnumerable();
        }
    }
}
