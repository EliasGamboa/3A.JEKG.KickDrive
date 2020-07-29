using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service
{
    public class ContainerRepository2 : SQLRepository<ProcesoRevision>//IContainerRepository
    {
        public ContainerRepository2(AppDBContext context) : base(context) { }
        public IEnumerable<Supervisor> GetSupervisors()
        {
            return context.Set<Supervisor>().AsEnumerable();
        }
    }
}