using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class LoginConcrete : ILogin
    {
        private uma_testContext _context;

        public LoginConcrete(uma_testContext context)
        {
            _context = context;
        }

        public Registration ValidateUser(string userName, string passWord)
        {
            try
            {


                var validate = (from user in _context.Registration
                                where user.Username == userName && user.Password == passWord
                                select user).SingleOrDefault();

                return validate;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdatePassword(Registration Registration)
        {
            _context.Registration.Attach(Registration);
            _context.Entry(Registration).Property(x => x.Password).IsModified = true;
            int result = _context.SaveChanges();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
