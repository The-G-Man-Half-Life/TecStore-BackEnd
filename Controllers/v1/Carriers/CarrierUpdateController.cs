using System.Timers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/[controller]")]
public class CarrierUpdateController(CarrierServices CarrierServices): CarrierController(CarrierServices)
{
    [HttpPut("{id}")]
    public async Task<ActionResult<Carrier?>> UpdateCarrier([FromRoute]int id, [FromBody]Carrier Carrier)
    {
        if (await CarrierServices.CheckExistence(id)== false)
        {
            return NotFound("El transportador no existe");
        }
        else
        {
            try
            {
                await CarrierServices.Update(Carrier);
                return Ok("Se actualizo correctamente");
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("Un error ocurrio", dbEX);
            }
        }
    }
}