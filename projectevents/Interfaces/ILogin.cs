﻿using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Interfaces
{
    public interface ILogin
    {
        Registration ValidateUser(string userName, string passWord);
        bool UpdatePassword(Registration Registration);
    }
}
