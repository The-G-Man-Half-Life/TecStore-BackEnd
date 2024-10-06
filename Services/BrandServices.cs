using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Services;
public class BrandServices: IBrandRepository
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
            return await Context.Brands.ToListAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<Brand?> GetById(int id)
    {
        try
        {
            return await Context.Brands.FirstOrDefaultAsync(b=>b.Brand_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Add(Brand Brand)
    {
        try
        {
            await Context.Brands.AddAsync(Brand);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Update(Brand Brand)
    {
        try
        {
            Context.Brands.Update(Brand);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Delete(int id)
    {
        try
        {
            var brandFound = await GetById(id);
            Context.Brands.Update(brandFound);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await Context.Brands.AnyAsync(b=>b.Brand_id == id); 

    }

}