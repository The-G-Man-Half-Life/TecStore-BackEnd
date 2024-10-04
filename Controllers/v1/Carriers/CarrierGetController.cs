using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers
{
    [ApiController]
    [Route("api/v1/Carriers/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Carriers")]
    public class CarrierGetController : CarrierController
    {
        private readonly CarrierServices CarrierServices;

        public CarrierGetController(CarrierServices CarrierServices) : base(CarrierServices)
        {
            this.CarrierServices = CarrierServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrier>>> GetAll()
        {
            try
            {
                var carriers = await CarrierServices.GetAll();
                return Ok(carriers);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Carrier>> GetCarrierById([FromRoute]int id)
        {
            if (await CarrierServices.CheckExistence(id) == false)
            {
                return NotFound();
            }
            try
            {
                var foundCarrier = await CarrierServices.GetById(id);
                return Ok(foundCarrier);
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Un error ocurrió durante el proceso");
            }
        }
    }
}
