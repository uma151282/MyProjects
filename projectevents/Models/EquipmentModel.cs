using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Models
{
    [NotMapped]
    public class EquipmentModel
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        [NotMapped]
        public bool EquipmentChecked { get; set; }
    }
}
