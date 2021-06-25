using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectevents.Interfaces;
using projectevents.Models;

namespace projectevents.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityAPIController : ControllerBase
    {
        private ICity _ICity;

        public CityAPIController(ICity ICity)
        {
            _ICity = ICity;
        }

        // POST api/values
        [HttpPost]
        public List<City> Post(string id)
        {
            try
            {
                var listofState = _ICity.ListofCity(Convert.ToInt32(id));
                return listofState;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}