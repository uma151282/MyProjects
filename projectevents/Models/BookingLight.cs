using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectevents.Models
{
    public class BookingLight
    {
        [Key]
        public int BookLightID { get; set; }
        public string LightType { get; set; }
        public int? LightIDSelected { get; set; }
        public int? BookingID { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }

        [NotMapped]
        public List<LightModel> LightList { get; set; }
    }
}
