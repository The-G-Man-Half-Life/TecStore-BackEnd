using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Controllers.v1.Brands;

[ApiController]
[Route("api/v1/Brands/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Brands")]
public class BrandController : ControllerBase
{   
    protected readonly IBrandRepository BrandRepository;

    public BrandController(IBrandRepository BrandRepository)
    {
        this.BrandRepository = BrandRepository;
    }
}