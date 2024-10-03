using System.Runtime.CompilerServices;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Shipments")]
public class ShipmentUpdateController(ShipmentServices ShipmentServices) : ShipmentController(ShipmentServices)
{
    [HttpPut("{id}")]
    public async Task<IActionResult> update([FromRoute] int id,[FromBody]ShipmentDTO shipmentDTO)
    {
        if(await ShipmentServices.CheckExistence(id)== false)
        {
            return NotFound("No se encontro a ninguna persona con ese id");
        }
        if (ModelState.IsValid == false)
        {
            return NotFound("El modelo debe de ser valido");
        }
        var shipment = await ShipmentServices.GetById(id);
        if (shipment == null)
        {
            return NotFound("No se encontro el objeto por su id");
        }
        else
        {
            shipment.Shipment_weight_kg = shipmentDTO.ShipmentWeightKG;
            shipment.Shipment_price_usa = shipmentDTO.ShipmentPriceUSA;
            shipment.Shipment_order_date = shipmentDTO.ShipmentOrderDate;
            shipment.Shipment_arrival_date = shipmentDTO.ShipmentArrivalDate;
            shipment.Carrier_id = shipmentDTO.CarrierId;
            await ShipmentServices.Update(shipment);
            return Ok("se agrego exitosamente");
        }
    }
}