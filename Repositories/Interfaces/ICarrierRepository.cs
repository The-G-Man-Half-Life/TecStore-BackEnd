using TechStore_BackEnd.Models;

namespace TechStore_BackEnd.Repositories.Interfaces;
public interface ICarrierRepository
{
    Task<IEnumerable<Carrier>> GetAll();
    Task<Carrier?> GetById(int id);
    Task Add(Carrier Carrier);
    Task Update(Carrier Carrier);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}