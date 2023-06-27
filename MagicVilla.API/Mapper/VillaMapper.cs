using System;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;

namespace MagicVilla.API.Mapper
{
    public static class VillaMapper
    {
        public static Villa VillaDtoToVilla(this VillaDto villaDto)
            => new Villa(villaDto.Name!)
            {
                CodVilla = villaDto.CodVilla,
                Details = villaDto.Details,
                Rate = villaDto.Rate,
                Sqft = villaDto.Sqft,
                Occupancy = villaDto.Occupancy,
                imageUrl = villaDto.imageUrl,
                Amenity = villaDto.Amenity
            };


        public static VillaDto VillaToVillaDto(this Villa villa)
            => new VillaDto
            {
                Name = villa.Name,
                CodVilla = villa.CodVilla,
                Details = villa.Details,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
                Occupancy = villa.Occupancy,
                imageUrl = villa.imageUrl,
                Amenity = villa.Amenity
            };


        public static IEnumerable<Villa> ToListVilla(this IList<VillaDto> listVillaDto)
            => listVillaDto.Select(v => v.VillaDtoToVilla());


        public static IEnumerable<VillaDto> ToListVillaDto(this IList<Villa> listVilla)
            => listVilla.Select(v => v.VillaToVillaDto());
    }

}
