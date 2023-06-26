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
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
            => Ok(VillaStore.VillaStorage.ToListVillaDto());



        [HttpGet]
        [Route("villa")]
        public ActionResult<VillaDto> GetVilla(string codVilla)
        {

            var villa = VillaStore.VillaStorage.Where(n => n.CodVilla! == codVilla).FirstOrDefault();

            if (villa is not null)
                return Ok(villa.VillaToVillaDto());

            return NotFound();
        }

    }
}

