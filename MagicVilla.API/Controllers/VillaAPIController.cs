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
        [Route("villas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<VillaDto>))]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
            => Ok(VillaStore.VillaStorage.ToListVillaDto());



        [HttpGet]
        [Route("villa")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> GetVilla(string codVilla)
        {

            var villa = VillaStore.VillaStorage.Where(n => n.CodVilla! == codVilla).FirstOrDefault();

            if (villa is null)
                return NotFound();

            return Ok(villa.VillaToVillaDto());

        }

    }
}

