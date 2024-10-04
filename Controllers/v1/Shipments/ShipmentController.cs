using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Shipments;

[ApiController]
[Route("api/v1/Shipments/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Shipments")]
public class ShipmentController(ShipmentServices ShipmentServices) : ControllerBase
{
    protected readonly ShipmentServices ShipmentServices = ShipmentServices;
}