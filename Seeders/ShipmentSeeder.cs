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
        int value = 1;
        int value2 =1; 
        
        var faker = new Faker<Shipment>()
                .RuleFor(s => s.Shipment_weight_kg, f => f.Random.Double(1.0, 100.0)) // Peso entre 1kg y 100kg
                .RuleFor(s => s.Shipment_price_usa, f => f.Random.Double(10.0, 1000.0)) // Precio entre 10 y 1000 USD
                .RuleFor(s => s.Shipment_order_date, f => DateOnly.FromDateTime(f.Date.Past(1))) // Fecha de pedido en el último año
                .RuleFor(s => s.Shipment_arrival_date, f => DateOnly.FromDateTime(f.Date.Future(1, DateTime.Now))) // Fecha de llegada en el próximo año
                .RuleFor(s => s.Carrier_id, f => f.Random.Int(1, 50));

        return faker.Generate(count);
    }
}
