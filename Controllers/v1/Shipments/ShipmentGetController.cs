using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments;

[ApiController]
[Route("api/v1/shipments/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Shipments")]
public class ShipmentGetController(ShipmentServices ShipmentServices) : ShipmentController(ShipmentServices)
{
    [HttpGet]
    public async Task<IActionResult<IEnumerable<Shipments>>> GetAll()
    {
        var shipments =await ShipmentServices.GetAll();
        if (shipments.Count()== 0)
        {
            return NoContent();
        }
        else
        {
            await ShipmentServices.GetAll();
        }
    }
}