using Bogus;
using TechStore_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
namespace TechStore_BackEnd.Seeders;
public class CarrierSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Carriers = GenerateCarriers(100);
        modelBuilder.Entity<Brand>().HasData(Carriers);
    }

    public static IEnumerable<Brand> GenerateCarriers(int count)
    {    
        var faker = new Faker<Brand>()
            .RuleFor(b => b.Brand_name, f => f.Company.CompanyName()) 
            .RuleFor(b => b.Brand_description, f => f.Lorem.Sentence(10));

        return faker.Generate(count);
    }
}
