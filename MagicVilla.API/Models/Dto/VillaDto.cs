using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla.API.Models.Dto
{
    public class VillaDto
    {
        public string? Name { get; set; }

        public string? CodVilla { get; set; }

        public string? Details { get; set; }

        public double Rate { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }

        public string? imageUrl { get; set; }

        public string? Amenity { get; set; }

    }
}

