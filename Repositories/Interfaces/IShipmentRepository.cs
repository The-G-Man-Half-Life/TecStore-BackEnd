using TechStore_BackEnd.Models;

namespace TechStore_BackEnd.Repositories.Interfaces;
public interface IShipmentRepository
{
    Task<IEnumerable<Shipment>> GetAll();
    Task<Shipment?> GetById(int id);
    Task<IEnumerable<Shipment>> GetByKeyword(string keyword);
    Task Add(Shipment shipment);
    Task Update(Shipment shipment);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}