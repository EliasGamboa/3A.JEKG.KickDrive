using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface IRepository3
    {
        public IEnumerable<Supervisor> getall();
    }
}
