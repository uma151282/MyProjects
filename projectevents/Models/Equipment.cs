﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectevents.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentID { get; set; }
        [Required(ErrorMessage = "EquipmentName Required")]
        public string EquipmentName { get; set; }
        public string EquipmentFilename { get; set; }
        public string EquipmentFilePath { get; set; }
        public int? Createdby { get; set; }
        public DateTime? Createdate { get; set; }
        [Required(ErrorMessage = "EquipmentName Required")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only numeric number")]
        public int? EquipmentCost { get; set; }


    }
}
