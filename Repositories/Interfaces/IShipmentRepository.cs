using TechStore_BackEnd.Models;

namespace TechStore_BackEnd.Repositories.Interfaces;
public interface IShipmentRepository
{
    Task<IEnumerable<ShipmentDTO>> GetAll();
    Task<ShipmentDTO?> GetById(int id);
    Task Add(Shipment shipment);
    Task Update(Shipment shipment);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}