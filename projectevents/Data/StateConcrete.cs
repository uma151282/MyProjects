using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class StateConcrete : IState
    {
        private uma_testContext _context;

        public StateConcrete(uma_testContext context)
        {
            _context = context;
        }

        public List<States> ListofState(int? ID)
        {
            if (ID == null)
            {
                return new List<States>();
            }

            var listofState = (from states in _context.States
                               where states.CountryID == ID
                               select states).ToList();

            listofState.Insert(0, new States { StateID = 0, StateName = "----Select----" });

            return listofState;
        }
    }
}
