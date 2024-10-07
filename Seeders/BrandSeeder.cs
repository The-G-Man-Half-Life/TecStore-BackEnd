using Bogus;
using TechStore_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace TechStore_BackEnd.Seeders;
public class BrandSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var brands = GenerateBrands(100);
        modelBuilder.Entity<Brand>().HasData(brands);
    }

    public static IEnumerable<Brand> GenerateBrands(int count)
    {    
        var faker = new Faker<Brand>()
            .RuleFor(b => b.Brand_name, f => f.Company.CompanyName()) 
            .RuleFor(b => b.Brand_description, f => f.Lorem.Sentence(10));

        return faker.Generate(count);
    }
}
