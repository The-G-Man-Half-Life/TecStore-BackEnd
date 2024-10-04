using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments
{
    [ApiController]
    [Route("api/v1/Shipments/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Tags("Shipments")]
    public class ShipmentDeleteController: ShipmentController
    {
        public readonly ShipmentServices ShipmentServices;
        public ShipmentDeleteController(ShipmentServices ShipmentServices): base(ShipmentServices)
        {
            this.ShipmentServices = ShipmentServices;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            if(await ShipmentServices.CheckExistence(id) == false)
            {
                return NoContent();
            }
            else
            {
                await ShipmentServices.Delete(id);
                return Ok("se borro el shipment");
            }
        }
    }
}