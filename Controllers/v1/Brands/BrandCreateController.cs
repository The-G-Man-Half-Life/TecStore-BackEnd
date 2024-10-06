using Microsoft.AspNetCore.Mvc;
using TechStore_BackEnd.DTOs.Requests;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Brands;

[ApiController]
[Route("api/v1/Brands/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Brands")]
public class BrandCreateController : BrandController
{
    private readonly BrandServices BrandServices;

    public BrandCreateController(BrandServices BrandServices) : base(BrandServices)
    {
        this.BrandServices = BrandServices;
    }
    [HttpPost]
    public async Task<IActionResult> CreateNewBrand([FromBody]BrandDTO BrandDTO)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if(BrandDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            var newBrand = new Brand(
                BrandDTO.Brand_name,
                BrandDTO.Brand_description
            );
            await BrandServices.Add(newBrand);
            return Ok(BrandServices);
        }
    }
}

