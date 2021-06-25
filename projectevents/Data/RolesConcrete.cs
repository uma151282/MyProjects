using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class RolesConcrete : IRoles
    {
        private uma_testContext _context;

        public RolesConcrete(uma_testContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Get RoleID Name by RoleName
        /// </summary>
        /// <param name="Rolename"></param>
        /// <returns></returns>
        public int getRolesofUserbyRolename(string Rolename)
        {
            var roleID = (from role in _context.Roles
                          where role.Rolename == Rolename
                          select role.RoleID).SingleOrDefault();

            return roleID;
        }
    }
}
