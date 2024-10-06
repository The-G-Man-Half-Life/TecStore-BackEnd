using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Brands;

[ApiController]
[Route("api/v1/Brands/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Brands")]

public class BrandDeleteController : ControllerBase
{
    public readonly BrandServices BrandServices;

    public BrandDeleteController(BrandServices BrandServices)
    {
        this.BrandServices = BrandServices;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteABrand([FromRoute] int id)
    {
        if(await BrandServices.CheckExistence(id) == false)
        {
            return NotFound();
        }
        else
        {
            await BrandServices.Delete(id);
            return Ok("se elimino exitosamente");
        }
    }
}