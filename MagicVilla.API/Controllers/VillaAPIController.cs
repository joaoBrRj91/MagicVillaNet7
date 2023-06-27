using AutoMapper;
using MagicVilla.API.Data;
using MagicVilla.API.Logging;
using MagicVilla.API.Logging.Interfaces;
using MagicVilla.API.Mapper;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly IGenerationLogging logging;
        private readonly ApplicationDbContext applicationDb;
        private readonly IMapper mapper;

        public VillaAPIController(IGenerationLogging logging, ApplicationDbContext applicationDb, IMapper mapper)
        {
            this.logging = logging;
            this.applicationDb = applicationDb;
            this.mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<VillaDto>))]
        public async Task<ActionResult<IEnumerable<VillaDto>>> GetVillas()
        {

            var villas = await applicationDb.Villas.AsNoTracking().ToListAsync();
            return Ok(mapper.Map<List<VillaDto>>(villas));
        }


        [HttpGet]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> GetVilla(string codVilla)
        {

            var villa = applicationDb.Villas.AsNoTracking().Where(n => n.CodVilla! == codVilla).FirstOrDefault();

            if (villa is null)
            {
                logging.Log($"Not found villa with {codVilla}", Logging.Enums.LogLevelCustomLogEnum.Error);
                return NotFound();
            }

            logging.Log("Response Villa", Logging.Enums.LogLevelCustomLogEnum.Info);

            return Ok(villa.VillaToVillaDto());

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaDto>> CreateVilla([FromBody]VillaCreateDto villaDto)
        {
            if (villaDto is null)
                return BadRequest(villaDto);

            if(!string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest(villaDto);

            var villa = villaDto.VillaDtoToVilla();
            await applicationDb.Villas.AddAsync(villa);
            await applicationDb.SaveChangesAsync();

            return StatusCode(StatusCodes.Status201Created, villa.VillaToVillaDto());
        }


        [HttpDelete]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteVilla(string codVilla)
        {
            if (string.IsNullOrEmpty(codVilla))
                return BadRequest();

            var villa = applicationDb.Villas.AsNoTracking().Where(v => v.CodVilla == codVilla).FirstOrDefault();

            if (villa is null)
                return NotFound();

            applicationDb.Villas.Remove(villa);
           await applicationDb.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVilla([FromBody] VillaUpdateDto villaDto)
        {
            if (villaDto is null || string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest();

            var villa = applicationDb.Villas.AsNoTracking().Where(v => v.CodVilla == villaDto.CodVilla).FirstOrDefault();

            villa!.Name = villaDto.Name;

            applicationDb.Update(villa);
            await applicationDb.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(string codVilla, [FromBody] JsonPatchDocument<VillaUpdateDto> patchDto)
        {

            if (patchDto is null || string.IsNullOrEmpty(codVilla))
                return BadRequest();

            var villa = VillaStore.VillaStorage.Where(v => v.CodVilla == codVilla).FirstOrDefault();
            var villaDto = (VillaUpdateDto)villa!.VillaToVillaDto();

            patchDto.ApplyTo(villaDto);

            villa = villaDto.VillaDtoToVilla();

            applicationDb.Update(villa);
            await applicationDb.SaveChangesAsync();

            return NoContent();
        }


    }
}

