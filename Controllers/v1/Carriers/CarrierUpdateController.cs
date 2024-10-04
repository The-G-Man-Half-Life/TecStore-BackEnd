using System.Timers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.DTOs.Requests;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/v1/Carriers/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Carriers")]
public class CarrierUpdateController : CarrierController
{
    private readonly CarrierServices CarrierServices;

    public CarrierUpdateController(CarrierServices CarrierServices) : base(CarrierServices)
    {
        this.CarrierServices = CarrierServices;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Carrier?>> UpdateCarrier([FromRoute] int id, [FromBody] CarrierDTO CarrierDTO)
    {
        if(await CarrierServices.CheckExistence(id)== false)
        {
            return NotFound("No se encontro a ningun transportador con ese id");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser valido");
        }
        var carrier = await CarrierServices.GetById(id);
        if (carrier == null)
        {
            return NotFound("No se encontro el objeto por su id");
        }
        else
        {
            carrier.Carrier_id = id;
            carrier.Carrier_name = CarrierDTO.Carrier_name;
            carrier.Carrier_description = CarrierDTO.Carrier_description;
            await CarrierServices.Update(carrier);
            return Ok("se agrego exitosamente");
        }
    }
}