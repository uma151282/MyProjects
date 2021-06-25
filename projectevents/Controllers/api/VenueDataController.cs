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
    public class VenueDataController : Controller
    {
        private IVenue _IVenue;
        public VenueDataController(IVenue IVenue)
        {
            _IVenue = IVenue;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Venue> Get()
        {
            return _IVenue.ShowAllVenue();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Venue Get(int id)
        {
            return _IVenue.VenueByID(id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _IVenue.DeleteVenue(id);
            return "Success";
        }
    }
}