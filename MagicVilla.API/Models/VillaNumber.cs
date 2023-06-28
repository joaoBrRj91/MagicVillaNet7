using System;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.API.Models
{

    [Index(nameof(VillaNo), IsUnique = true)]
    public class VillaNumber : BaseEntity
	{
        public VillaNumber(ushort villaNo, string specialDetails)
        {
            VillaNo = villaNo;
            SpecialDetails = specialDetails;
        }

        protected VillaNumber()
        {

        }

        public ushort VillaNo { get; set; }

		public string SpecialDetails { get; set; }
	}
}

