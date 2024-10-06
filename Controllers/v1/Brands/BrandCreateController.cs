using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IActionResult> CreateNewBrand([FromBody] BrandDTO BrandDTO)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest("The model is bad done");
        }
        else if (BrandDTO == null)
        {
            return BadRequest("The model can not be null");
        }
        else
        {
            try
            {
                var newBrand = new Brand(
                BrandDTO.Brand_name,
                BrandDTO.Brand_description
            );
                await BrandServices.Add(newBrand);
                return Ok(newBrand);
            }
            catch (DbUpdateException dbEX)
            {
                throw new Exception("Un error ocurrio",dbEX);
            }

        }
    }
}

