using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetZen.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        public ActivityEnum ActType { get; set; }

        [Required]
        [ForeignKey(nameof(Pet))]
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Notes { get; set; }
    }
}