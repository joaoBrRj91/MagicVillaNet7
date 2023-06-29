using System;
using MagicVilla.API.Models.Dto;
using MagicVilla.API.Models.Response.Interface;

namespace MagicVilla.API.Services.Interfaces
{
	public interface IVillaService
	{
		Task<IResponse> GetVillaDtosAsync();
	}
}

