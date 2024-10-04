using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipmentCreateController(ShipmentServices ShipmentServices) : ShipmentController(ShipmentServices)
    {
        [HttpPost]
        
    }
}