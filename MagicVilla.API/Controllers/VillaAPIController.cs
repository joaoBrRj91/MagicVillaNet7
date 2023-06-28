using AutoMapper;
using MagicVilla.API.Mapper;
using MagicVilla.API.Models.Dto;
using MagicVilla.API.Repositories.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly IVillaRepository villaRepository;
        private readonly IMapper mapper;

        public VillaAPIController(IVillaRepository villaRepository, IMapper mapper)
        {
            this.villaRepository = villaRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<VillaDto>))]
        public async Task<ActionResult<IEnumerable<VillaDto>>> GetVillas()
        {

            var villas = await villaRepository.GetAllAsync();
            return Ok(mapper.Map<List<VillaDto>>(villas));
        }


        [HttpGet]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDto>> GetVilla(string codVilla)
        {

            var villa =  await villaRepository.GetAsync(n => n.CodVilla! == codVilla);

            if (villa is null)
            {
                return NotFound();
            }


            return Ok(villa.VillaToVillaDto());

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaDto>> CreateVilla([FromBody] VillaCreateDto villaDto)
        {
            if (villaDto is null)
                return BadRequest(villaDto);

            if (!string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest(villaDto);

            var villa = villaDto.VillaDtoToVilla();

            await villaRepository.CreateAsync(villa);
            await villaRepository.SaveChangesAysnc();

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

            var villa = await villaRepository.GetAsync(v => v.CodVilla == codVilla);

            if (villa is null)
                return NotFound();

            await villaRepository.RemoveAsync(villa);
            await villaRepository.SaveChangesAysnc();

            return NoContent();
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVilla([FromBody] VillaUpdateDto villaDto)
        {
            if (villaDto is null || string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest();

            var villa = await villaRepository.GetAsync(v => v.CodVilla == villaDto.CodVilla);

            villa!.Name = villaDto.Name;

            await villaRepository.UpdateAsync(villa);
            await villaRepository.SaveChangesAysnc();

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

            var villa = await villaRepository.GetAsync(v => v.CodVilla == codVilla);
            var villaDto = (VillaUpdateDto)villa!.VillaToVillaDto();

            patchDto.ApplyTo(villaDto);

            villa = villaDto.VillaDtoToVilla();

            await villaRepository.UpdateAsync(villa);
            await villaRepository.SaveChangesAysnc();

            return NoContent();
        }


    }
}

