using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class DishtypesConcrete : IDishtypes
    {
        private uma_testContext _context;

        public DishtypesConcrete(uma_testContext context)
        {
            _context = context;
        }

        public List<Dishtypes> GetDishtypeList()
        {

            try
            {
                return _context.Dishtypes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
