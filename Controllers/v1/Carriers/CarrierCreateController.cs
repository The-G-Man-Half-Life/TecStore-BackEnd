using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.DTOs.Requests;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/v1/Carriers/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Carriers")]
public class CarrierCreateController : CarrierController
{
    private readonly CarrierServices CarrierServices;

    public CarrierCreateController(CarrierServices CarrierServices) : base(CarrierServices)
    {
        this.CarrierServices = CarrierServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCarrier([FromBody]CarrierDTO CarrierDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(CarrierDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newCarrier = new Carrier(
                CarrierDTO.Carrier_name,
                CarrierDTO.Carrier_description
            );
            await CarrierServices.Add(newCarrier);
            return Ok(newCarrier);
        }
    }
}