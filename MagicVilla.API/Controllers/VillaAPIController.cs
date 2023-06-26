using MagicVilla.API.Data;
using MagicVilla.API.Mapper;
using MagicVilla.API.Models.Dto;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> CreateVilla([FromBody]VillaDto villaDto)
        {
            if (villaDto is null)
                return BadRequest(villaDto);

            if(!string.IsNullOrEmpty(villaDto.CodVilla))
                return BadRequest(villaDto);

            var villa = villaDto.VillaDtoToVilla();
            VillaStore.VillaStorage.Add(villa);

            return Ok(villa.VillaToVillaDto());
        }
    }
}

