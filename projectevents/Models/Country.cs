using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string Name { get; set; }
    }
}
