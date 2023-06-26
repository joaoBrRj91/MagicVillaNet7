using MagicVilla.API.Mapper;
using MagicVilla.API.Models;
using MagicVilla.API.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {

        private static IList<Villa> _villaStorage = new List<Villa>
            {
                new Villa("Pool View"),
                new Villa("Beach View")
            };


        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return Ok(_villaStorage.ToListVillaDto());
        }

    }
}

