using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Shipments")]
    public class ShipmentCreateController(ShipmentServices ShipmentServices) : ShipmentController(ShipmentServices)
    {
        [HttpPost]
        public async Task<IActionResult> CreateNewShipment([FromBody]ShipmentDTO ShipmentDTO)
        {
            if (ModelState.IsValid == false)
            {
                return NotFound("Something is wrong about the creation");
            }
            else
            {
                var newShipment = new Shipment(
                    ShipmentDTO.ShipmentWeightKG,
                    ShipmentDTO.ShipmentPriceUSA,
                    ShipmentDTO.ShipmentArrivalDate,
                    ShipmentDTO.ShipmentOrderDate,
                    ShipmentDTO.CarrierId
                );
                await ShipmentServices.Add(newShipment);
                return Ok("se agrego exitosamente");
            }
        }
    }
}