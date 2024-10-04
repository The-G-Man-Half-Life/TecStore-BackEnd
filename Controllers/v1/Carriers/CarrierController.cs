using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/v1/Carriers/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Carriers")]
public class CarrierController(CarrierServices CarrierServices): ControllerBase
{
    protected readonly CarrierServices CarrierServices  = CarrierServices;
}