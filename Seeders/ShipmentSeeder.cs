using Bogus;
using TechStore_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace TechStore_BackEnd.Seeders;
public class ShipmentSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Shipments = GenerateShipments(100);
        modelBuilder.Entity<Shipment>().HasData(Shipments);
    }

    public static IEnumerable<Shipment> GenerateShipments(int count)
    {
        int id = 1; 
        
        var faker = new Faker<Shipment>()
            .RuleFor(b => b.Shipment_id, f => id++) 
            .RuleFor(b => b.Shipment_name, f => f.Company.CompanyName()) 
            .RuleFor(b => b.Shipment_description, f => f.Lorem.Sentence(10));

        return faker.Generate(count);
    }
}
