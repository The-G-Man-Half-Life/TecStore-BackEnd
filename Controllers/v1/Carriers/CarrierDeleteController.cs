using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;
public class CarrierDeleteController(CarrierServices CarrierServices): CarrierController(CarrierServices)
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCarrier([FromRoute] int id)
    {
        if(await CarrierServices.CheckExistence(id)== false)
        {
            return BadRequest("El transportador no existe");
        }
        else
        {
            try
            {
                await CarrierServices.Delete(id);
                return Ok("fue un exito");
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}