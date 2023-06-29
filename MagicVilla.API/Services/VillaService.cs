using System;
using System.Net;
using System.Text.Json;
using AutoMapper;
using MagicVilla.API.Logging.Interfaces;
using MagicVilla.API.Models.Dto;
using MagicVilla.API.Models.Response;
using MagicVilla.API.Models.Response.Interface;
using MagicVilla.API.Repositories.Interfaces;
using MagicVilla.API.Services.Interfaces;

namespace MagicVilla.API.Services
{
	public class VillaService : IVillaService
	{
        private readonly IVillaRepository villaRepository;
        private readonly IGenerationLogging logging;
        private readonly IMapper mapper;
        private IResponse response;

        public VillaService(IVillaRepository villaRepository, IGenerationLogging logging, IMapper mapper)
		{
            this.villaRepository = villaRepository;
            this.logging = logging;
            this.mapper = mapper;
            this.response = new ApiResponse
                (HttpStatusCode.InternalServerError,
                HttpStatusCode.InternalServerError.ToString(),
                errorMessages: new List<string>(),
                result: new());
        }

        public async Task<IResponse> GetVillaDtosAsync()
        {
            var apiResponse = response as ApiResponse;

            try
            {
                var villas = await villaRepository.GetAllAsync();
                var villasDto = mapper.Map<List<VillaDto>>(villas);

                apiResponse!.StatusCode = HttpStatusCode.OK;
                apiResponse.StatusCodeMessage = HttpStatusCode.OK.ToString();
                apiResponse.Result = JsonSerializer.Serialize(villasDto, new JsonSerializerOptions { WriteIndented = true });

                logging.Log(mensage: "GetAllAsync Villas is success", LogLevel.Information, apiResponse.Result.ToString());
            }
            catch (Exception ex)
            {
                response.ErrorMessages = new List<string> { ex.Message, ex.InnerException!.Message };

                logging.Log(mensage: string.Join(';', response.ErrorMessages), LogLevel.Information, apiResponse!.Result.ToString());

            }

            return response;
        }
    }
}

