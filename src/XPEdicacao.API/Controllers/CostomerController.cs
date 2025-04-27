using Microsoft.AspNetCore.Mvc;
using XPEducacao.API.Models;
using XPEducacao.API.Services;


namespace XPEducacao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostomerController : ControllerBase
    {

        private readonly ICostumerService _services;

        public CostomerController(ICostumerService services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_services.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var costomer = _services.Get(id);
            if (costomer == null) return NotFound();
            return Ok(costomer);
        }


        [HttpGet("search")]
        public IActionResult GetByName([FromQuery] string name) => Ok(_services.GetByName(name));

        [HttpPost]
        public void Post([FromBody] CostumerRecord record)
        {
            _services.Add(record);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, CostumerRecord updatedCostomer)
        {
            var existingProduct = _services.Get(id);
            if (existingProduct == null) return NotFound();
            _services.Update(updatedCostomer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var product = _services.Get(id);
            if (product == null) return NotFound();
            _services.Delete(id);
            return NoContent();
        }
    }
}
