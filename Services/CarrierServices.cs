using System.Linq.Expressions;
using Bogus.DataSets;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Services;
public class CarrierServices : ICarrierRepository
{
    public readonly ApplicationDbContext Context;

    public CarrierServices(ApplicationDbContext context)
    {
        Context = context;
    }

    public async Task<IEnumerable<Carrier>> GetAll()
    {
        return await Context.Carriers.ToListAsync();
    }
    public async Task<Carrier?> GetById(int id)
    {
        try
        {
            return await Context.Carriers.FirstOrDefaultAsync(c => c.Carrier_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception("Un error ocurrio", dbEX);

        }
    }
    public async Task Add(Carrier Carrier)
    {
        if (Carrier == null)
        {
            throw new ArgumentNullException(nameof(Carrier), "el transportador no puede ser nulo");
        }
        else
        {
            try
            {
                await Context.Carriers.AddAsync(Carrier);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);
            }
        }

    }
    public async Task Update(Carrier Carrier)
    {
        if (Carrier == null)
        {
            throw new Exception("Un erro ocurrio");
        }

        else
        {
            try
            {
                Context.Update(Carrier);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);

            }
        }

    }
    public async Task Delete(int id)
    {
        try
        {
            var carrier = await GetById(id);
            if (carrier != null)
            {
                Context.Carriers.Remove(carrier);
            }
            
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
                throw new Exception("Un error ocurrio", dbEX);
        }
    }
    public async Task<bool> CheckExistence(int id)
    {
        return await Context.Carriers.AnyAsync(c => c.Carrier_id == id);
    }
}