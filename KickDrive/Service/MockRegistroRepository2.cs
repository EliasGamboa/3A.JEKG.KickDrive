using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Service
{
    public class MockRegistroRepository2 :IRepository2
    {
        private List<Conductor> _conductors;
        public MockRegistroRepository2()
        {
            _conductors = new List<Conductor>()
            {
                new Conductor {}
            };
        }
        public IEnumerable<Conductor> getall()
        {
            return _conductors;
        }
    }
}
