using MagicVilla.API.Data;
using MagicVilla.API.Mapper;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<VillaDto>))]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
            => Ok(VillaStore.VillaStorage.ToListVillaDto());


        [HttpGet]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> GetVilla(string codVilla)
        {
            
            var villa = VillaStore.VillaStorage.Where(n => n.CodVilla! == codVilla).FirstOrDefault();

            if (villa is null)
                return NotFound();

            return Ok(villa.VillaToVillaDto());

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> CreateVilla([FromBody]VillaDto villaDto)
        {
            if (villaDto is null)
                return BadRequest(villaDto);

            if(!string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest(villaDto);

            var villa = villaDto.VillaDtoToVilla();
            VillaStore.VillaStorage.Add(villa);

            return StatusCode(StatusCodes.Status201Created, villa.VillaToVillaDto());
        }


        [HttpDelete]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVilla(string codVilla)
        {
            if (string.IsNullOrEmpty(codVilla))
                return BadRequest();

            var villa = VillaStore.VillaStorage.Where(v => v.CodVilla == codVilla).FirstOrDefault();

            if (villa is null)
                return NotFound();

            VillaStore.VillaStorage.Remove(villa!);

            return NoContent();
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla([FromBody] VillaDto villaDto)
        {
            if (villaDto is null || string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest();

            var villa = VillaStore.VillaStorage.Where(v => v.CodVilla == villaDto.CodVilla).FirstOrDefault();

            villa!.Name = villaDto.Name;

            return NoContent();
        }

        [HttpPatch]
        [Route("codVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialVilla(string codVilla, [FromBody] JsonPatchDocument<VillaDto> patchDto)
        {

            if (patchDto is null || string.IsNullOrEmpty(codVilla))
                return BadRequest();

            var villa = VillaStore.VillaStorage.Where(v => v.CodVilla == codVilla).FirstOrDefault();
            var villaDto = villa!.VillaToVillaDto();

            patchDto.ApplyTo(villaDto);

            villa = villaDto.VillaDtoToVilla();

            return NoContent();
        }


    }
}

