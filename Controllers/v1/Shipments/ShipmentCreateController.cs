using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Controllers.v1.Carriers;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments;

[ApiController]
[Route("api/v1/Shipments/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Shipments")]
public class ShipmentCreateController: ShipmentController
{
    private readonly ShipmentServices ShipmentServices;

    public ShipmentCreateController(ShipmentServices ShipmentServices) : base(ShipmentServices)
    {
        this.ShipmentServices = ShipmentServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCarrier([FromBody]ShipmentDTO ShipmentDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(ShipmentDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newShipment = new Shipment(
                ShipmentDTO.ShipmentWeightKG,
                ShipmentDTO.ShipmentPriceUSA,
                ShipmentDTO.ShipmentOrderDate,
                ShipmentDTO.ShipmentArrivalDate,
                ShipmentDTO.CarrierId
            );
            await ShipmentServices.Add(newShipment);
            return Ok(newShipment);
        }
    }
}
