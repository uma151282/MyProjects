using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventType { get; set; }
        public string Status { get; set; }
    }
}
