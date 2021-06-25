using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int? StateID { get; set; }
    }
}
