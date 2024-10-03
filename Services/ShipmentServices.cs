using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Services;

public class ShipmentServices : IShipmentRepository
{
    private readonly ApplicationDbContext Context;

    public ShipmentServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<Shipment>> GetAll()
    {
        try
        {
            return await Context.Shipments.ToListAsync();
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio");
        }
    }

    public async Task<Shipment?> GetById(int id){

        try
        {
            return await Context.Shipments.FirstOrDefaultAsync(s=>s.Shipment_id == id);
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio durante el proceso");
        }
    }

    public async Task Add(Shipment shipment){
        try
        {
            await Context.Shipments.AddAsync(shipment);
            await Context.SaveChangesAsync();
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio durante el proceso");
        }
    }

    public async Task Update(Shipment shipment){
        try
        {
            Context.Shipments.Update(shipment);
            await Context.SaveChangesAsync();
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio durante el proceso");
        }
    }

    public async Task Delete(int id){
        try
        {
            var user = await GetById(id);
            Context.Shipments.Remove(user);
            await Context.SaveChangesAsync();
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio durante el proceso");
        }
    }

    public async Task<bool> CheckExistence(int id){
        return await  Context.Shipments.AnyAsync(s=>s.Shipment_id==id);
    }

}