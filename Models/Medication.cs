﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetZen.Models
{
    public class Medication
    {
        [Key]
        public int MedId { get; set; }

        [Required]
        public int MyProperty { get; set; }

        [Required]
        [ForeignKey(nameof(Pet))]
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        [Required]
        public double Dosage { get; set; }

        [Required]
        public int TimesPerDay { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string RefillLink { get; set; }

        
    }
}