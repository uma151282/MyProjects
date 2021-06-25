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
    public class CountryAPIController : ControllerBase
    {
        private ICountry _ICountry;

        public CountryAPIController(ICountry ICountry)
        {
            _ICountry = ICountry;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            try
            {
                var listofCountry = _ICountry.ListofCountry();
                listofCountry.Insert(0, new Country { CountryID = 0, Name = "----Select----" });
                return listofCountry;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}