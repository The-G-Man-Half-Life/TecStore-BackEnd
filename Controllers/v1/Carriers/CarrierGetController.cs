using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Services;

namespace TechStore_BackEnd.Controllers.v1.Carriers;

[ApiController]
[Route("api/[controller]")]
public class CarrierGetController(CarrierServices CarrierServices) : CarrierController(CarrierServices)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carrier>>> GetAllCarriers()
    {
        try
        {
            var carriers=await CarrierServices.GetAll();
            return Ok(carriers);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new DbUpdateException("Un error ocurrio durante el proceso",dbEX);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Carrier>> GetCarrierById([FromRoute]int id)
    {
        if(await CarrierServices.CheckExistence(id)== false)
        {
            return NotFound();
        }
        else
        {
            try
            {
                var foundCarrier =await CarrierServices.GetById(id);
                return Ok(foundCarrier);
            }
            catch (DbUpdateException dbEX)
            {
                
                throw new DbUpdateException("Un error ocurrio durante el proceso",dbEX);
            }
        }
    }
}