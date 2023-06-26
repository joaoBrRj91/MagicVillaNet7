using System;
using MagicVilla.API.Models;

namespace MagicVilla.API.Data
{
	public class VillaStore
	{
		public static IList<Villa> VillaStorage = new List<Villa>
            {
                new Villa("Pool View"),
                new Villa("Beach View")
            };
    }
}

