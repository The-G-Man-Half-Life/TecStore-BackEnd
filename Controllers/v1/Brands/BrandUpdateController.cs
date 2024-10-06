using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.DTOs.Requests;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Brands;

[ApiController]
[Route("api/v1/Brands/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags ("Brands")]
public class BrandUpdateController : BrandController
{
    public readonly BrandServices BrandServices;

    public BrandUpdateController(BrandServices BrandServices): base(BrandServices)
    {
        this.BrandServices = BrandServices;
    }

    [HttpPut("{id}")]


    public async Task<ActionResult> UpdateABrand([FromRoute] int id, [FromBody] BrandDTO BrandDTO)
    {
        if(ModelState.IsValid == false)
        {
            return NoContent();
        }
        else if(ModelState == null)
        {
            return BadRequest("No puede hacer un modelo vacio");
        }
        else if(await BrandServices.CheckExistence(id) == false)
        {
            return NoContent();
        }
        else
        {
            try
            {
                var foundBrand = await BrandServices.GetById(id);
                foundBrand.Brand_id = id;
                foundBrand.Brand_name = BrandDTO.Brand_name;
                foundBrand.Brand_description = BrandDTO.Brand_description;

                await BrandServices.Update(foundBrand);
                return Ok(foundBrand);
            }
            catch (DbUpdateException dbEX)
            {
                throw new DbUpdateException("Un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}