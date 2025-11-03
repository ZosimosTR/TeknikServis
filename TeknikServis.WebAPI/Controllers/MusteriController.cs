using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeknikServis.Business.Services;
using TeknikServis.Core.Entities;

namespace TeknikServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private readonly MusteriService _service;

        public MusteriController(MusteriService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var musteris = await _service.GetAllAsync();
            return Ok(musteris);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var musteri = await _service.GetByIdAsync(id);
            if (musteri == null)
                return NotFound();
            return Ok(musteri);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Musteri musteri)
        {
            await _service.AddAsync(musteri);
            return Ok(musteri);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Musteri musteri)
        {
            await _service.UpdateAsync(musteri);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
