﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla.API.Models
{
    public class Villa : BaseEntity
    {
        public Villa(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CodVilla = GeneratedCodVilla();
            CreatedDate = DateTime.Now;
        }

        protected Villa()
        {

        }


        public string? Name { get; set; }

        public string? CodVilla { get; set; }

        public string? Details { get; set; }

        public double Rate { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }

        public string? imageUrl { get; set; }

        public string? Amenity { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UodatedDate { get; set; }


        [ForeignKey("VillaNumber")]
        public Guid VillaNumberId { get; set; } 

        public VillaNumber VillaNumber { get; set; }


        private string GeneratedCodVilla()
        {
            var randomCodVilla = $"{Name!.ToUpper()}-{new Random().NextInt64()}";
            return randomCodVilla!;
        }
    }
}

