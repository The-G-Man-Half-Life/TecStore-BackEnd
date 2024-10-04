using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments;

[ApiController]
[Route("api/v1/Shipments/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Shipments")]
public class ShipmentGetController : ShipmentController
{
    public readonly ShipmentServices ShipmentServices;

    public ShipmentGetController(ShipmentServices ShipmentServices): base (ShipmentServices)
    {
        this.ShipmentServices = ShipmentServices;
    }

[HttpGet]
public async Task<ActionResult<IEnumerable<Shipment>>> GetAll()
{
    var shipments = await ShipmentServices.GetAll();
    return Ok(shipments);
}

[HttpGet("{id}")]
public async Task<ActionResult<Shipment>> GetById([FromRoute] int id)
{
    if (await ShipmentServices.CheckExistence(id) == false)
    {
        return NoContent();
    }
    else
    {
        var shipment = await ShipmentServices.GetById(id);
        return Ok(shipment);
    }

}
}