using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IRepository2
    {
        public IEnumerable<Conductor> getall();
    }
}
