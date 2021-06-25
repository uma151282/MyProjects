using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public class Dishtypes
    {
        [Key]
        public int ID { get; set; }
        public string Dishtype { get; set; }
    }
}
