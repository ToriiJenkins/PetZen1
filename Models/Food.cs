using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetZen.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public SpeciesEnum Species { get; set; }

        [Required]
        public double ServingSize { get; set; }

        public string PurchaseLink { get; set; }
    }
}