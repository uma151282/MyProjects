using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class CountryConcrete : ICountry
    {
        private uma_testContext _context;

        public CountryConcrete(uma_testContext context)
        {
            _context = context;
        }

        public List<Country> ListofCountry()
        {
            return _context.Country.ToList();
        }
    }
}
