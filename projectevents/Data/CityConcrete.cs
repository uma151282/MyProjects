using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class CityConcrete : ICity
    {
        private uma_testContext _context;

        public CityConcrete(uma_testContext context)
        {
            _context = context;
        }
        public List<City> ListofCity(int? ID)
        {
            if (ID == null)
            {
                return new List<City>();
            }

            var listofcity = (from city in _context.City
                               where city.StateID== ID
                               select city).ToList();

            listofcity.Insert(0, new City { CityID = 0, CityName = "----Select----" });

            return listofcity;
        }
    }
}
