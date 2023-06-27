using System;
using AutoMapper;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;

namespace MagicVilla.API.Mapper.AutoMapper
{
	public class AutoMappingConfig : Profile
	{
		public AutoMappingConfig()
		{
			CreateMap<Villa, VillaDto>().ReverseMap();

        }
    }
}

