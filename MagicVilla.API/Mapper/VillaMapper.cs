using System;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;

namespace MagicVilla.API.Mapper
{
    public static class VillaMapper
    {
        public static Villa VillaDtoToVilla(this VillaDto villaDto)
            => new Villa(villaDto.Name!);


        public static VillaDto VillaToVillaDto(this Villa villa)
            => new VillaDto
            {
                Name = villa.Name,
                CreatedDate = villa.CreatedDate
            };


        public static IEnumerable<Villa> ToListVilla(this IList<VillaDto> listVillaDto)
            => listVillaDto.Select(v => new Villa(v.Name!));


        public static IEnumerable<VillaDto> ToListVillaDto(this IList<Villa> listVilla)
            => listVilla
            .Select(v =>
            new VillaDto
            {
                Name = v.Name,
                CreatedDate = v.CreatedDate

            });
    }

}
