using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Brands;
    
[ApiController]
[Route("api/v1/Brands/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags ("Brands")]
public class BrandGetController : BrandController
{
    public readonly BrandServices BrandServices;

    public BrandGetController(BrandServices BrandServices): base(BrandServices)
    {
        this.BrandServices = BrandServices;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Brand>>> GetAllbrands()
    {
        try
        {
            var brands = await BrandServices.GetAll();
            return Ok(brands);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new DbUpdateException($"Un error ocurrio durante el proceso {dbEX.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Brand>> GetById([FromRoute] int id)
    {
        if(await BrandServices.CheckExistence(id) == false)
        {
            return NoContent();
        }
        else
        {
            try
            {
                var brandFound = await BrandServices.GetById(id);
                return Ok(brandFound);          
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("Un error ocurrio durante el proceso", dbEX);
            }

        }
    }
}