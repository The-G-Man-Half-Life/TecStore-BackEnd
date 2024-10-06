using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Controllers.v1.Brands;

[ApiController]
[Route("api/[controller]")]
public class BrandController : ControllerBase
{   
    private readonly IBrandRepository BrandRepository;

    public BrandController(IBrandRepository BrandRepository)
    {
        this.BrandRepository = BrandRepository;
    }
}