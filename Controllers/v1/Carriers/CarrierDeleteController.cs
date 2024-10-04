using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Repositories.Interfaces;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/v1/Carriers/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Carriers")]
public class CarrierDeleteController: CarrierController
{
    private readonly CarrierServices CarrierServices;

    public CarrierDeleteController(CarrierServices CarrierServices) : base(CarrierServices)
    {
        this.CarrierServices = CarrierServices;
    }

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
                await CarrierRepository.Delete(id);
                return Ok("fue un exito");
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}