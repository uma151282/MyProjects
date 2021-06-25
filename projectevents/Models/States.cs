using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public partial class States
    {
        [Key]
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int? CountryID { get; set; }
    }
}
