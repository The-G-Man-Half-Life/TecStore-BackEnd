using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/v1/Carriers/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Carriers")]
public class CarrierController: ControllerBase
{
    protected readonly ICarrierRepository CarrierRepository;

    public CarrierController(ICarrierRepository CarrierRepository)
    {
        this.CarrierRepository = CarrierRepository;
    }
}