using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla.API.Models.Dto
{
    public class VillaDto
    {
        public string? Name { get; set; }
        public string? CodVilla { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

