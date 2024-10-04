using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Services;
public class CarrierServices : ICarrierRepository
{
    public readonly ApplicationDbContext Context;

    public CarrierServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<Carrier>> GetAll()
    {
        try
        {
            return await Context.
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<Carrier?> GetById(int id);
    {

    }
    public async Task Add(Carrier Carrier);
    {

    }
    public async Task Update(Carrier Carrier);
    {

    }
    public async Task Delete(int id);
    {

    }
    public async Task<bool> CheckExistence(int id);
    {

    }
}