using Inventroy_System_API.Models;
using Inventroy_System_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inventroy_System_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSuppliers()
        {
            return Ok(await _supplierRepository.GetAllSuppliers());
        }
        [Route("GetSupplierByid")]
        [HttpGet]
        public async Task<IActionResult> GetSupplierByid(int id)
        {
            var supplier = await _supplierRepository.GetSupplierById(id);
            if (supplier == null) return NotFound();
            return Ok(supplier);
        }

        [Route("AddSupplier")]
        [HttpPost]
        public async Task<IActionResult> AddSupplier([FromBody] SupplierModel model)
        {
            var id = await _supplierRepository.AddSupplier(model);
            return CreatedAtAction(nameof(GetSupplierByid), new { id = id, controller = "Category" }, model);
        }
        [Route("UpdateSupplier")]
        [HttpPut]
        public async Task<IActionResult> UpdateSupplier(int id, [FromBody] SupplierModel model)
        {
            await _supplierRepository.UpdateSupplier(id, model);
            return NoContent();
        }

        [Route("DeleteSupplier")]
        [HttpPut]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            await _supplierRepository.DeleteSupplier(id);
            return NoContent();
        }
    }
}
