using TechStore_BackEnd.DTOs.Requests;
using TechStore_BackEnd.Models;

namespace TechStore_BackEnd.Repositories.Interfaces;
public interface IBrandRepository
{
    Task<IEnumerable<Brand>> GetAll();
    Task<Brand?> GetById(int id);
    Task Add(Brand Brand);
    Task Update(Brand Brand);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}