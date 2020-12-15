﻿using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetZen.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [Required]
        public string Name { get; set; }

        public SpeciesEnum Species { get; set; }

        public string Breed { get; set; }

        public double Weight { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public int MealsPerDay { get; set; }


    }
}