using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public partial class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public string Rolename { get; set; }
    }
}
