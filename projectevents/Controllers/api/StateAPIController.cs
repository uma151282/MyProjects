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
    public class StateAPIController : ControllerBase
    {
        private IState _IState;

        public StateAPIController(IState IState)
        {
            _IState = IState;
        }

        // POST api/values
        [HttpPost]
        public List<States> Post(string id)
        {
            try
            {
                if (id == null)
                {
                    return null;
                }

                var listofState = _IState.ListofState(Convert.ToInt32(id));
                return listofState;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}