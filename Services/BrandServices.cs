using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;

namespace TechStore_BackEnd.Services;
public class BrandServices
{
    public readonly ApplicationDbContext Context;

    public BrandServices(ApplicationDbContext context)
    {
        this.Context = Context;
    }
    public async Task<IEnumerable<Brand>> GetAll()
    {
        try
        {
            return await Context
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<Brand?> GetById(int id)
    {

    }

    public async Task Add(Brand Brand)
    {

    }

    public async Task Update(Brand Brand)
    {

    }

    public async Task Delete(int id)
    {

    }

    public async Task<bool> CheckExistence(int id)
    {

    }

}