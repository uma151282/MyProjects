using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectevents.Models
{
    public class BookingEquipment
    {
        [Key]
        public int BookingEquipmentID { get; set; }

        public int? EquipmentID { get; set; }

        public int? Createdby { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int BookingID { get; set; }

        [NotMapped]
        public List<EquipmentModel> EquipmentList { get; set; }


    }
}
