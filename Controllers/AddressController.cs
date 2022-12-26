using Microsoft.AspNetCore.Mvc;
using turkey_address.Repository;

namespace turkey_address.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IlceRepository _ılceRepository;
        private readonly SehirRepository _sehirRepository;
        private readonly SemtMahalleRepository _semtMahalleRepository;

        public AddressController(IlceRepository ılceRepository, SehirRepository sehirRepository, SemtMahalleRepository semtMahalleRepository)
        {
            this._ılceRepository = ılceRepository;
            this._sehirRepository = sehirRepository;
            this._semtMahalleRepository = semtMahalleRepository;
        }
        [HttpPost]
        [Route("city/view")]
        public async Task<IActionResult> getAllCity()
        {
            var sehirler = await _sehirRepository.getCitys();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(sehirler);
        }

        [HttpPost]
        [Route("county/view")]
        public async Task<IActionResult> getAllCountyFromId(int SehirId)
        {
            var ilceler = await _ılceRepository.getCountys(SehirId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(ilceler);
        }
        [HttpPost]
        [Route("street/view")]
        public async Task<IActionResult> getAllStreetFromId(int StreetId)
        {
            var semtMahalles = await _semtMahalleRepository.getStreets(StreetId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(semtMahalles);
        }
    }
}
