using System;
using System.Collections.Generic;

namespace projectevents.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Role { get; set; }
    }
}
