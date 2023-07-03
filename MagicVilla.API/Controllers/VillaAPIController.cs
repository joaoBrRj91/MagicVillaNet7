using MagicVilla.API.Models.Response.Interface;
using MagicVilla.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly IVillaService villaService;

        public VillaAPIController(IVillaService villaService) => this.villaService = villaService;

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        //[ProducesResponseType(StatusCodes.Status200OK,Type = typeof(IResponse))]
        public async Task<ActionResult<IResponse>> GetVillas()
        {

            var response = await villaService.GetVillaDtosAsync();
            return Ok(response);
        }

        #region Other Methods

        /*[HttpGet]
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
        }*/

        #endregion
    }
}

