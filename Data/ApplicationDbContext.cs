using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Seeders;

namespace TechStore_BackEnd.Data;
public class ApplicationDbContext: DbContext
{
    public DbSet<Shipment> Shipments {get; set;}
    public DbSet<Carrier> Carriers {get; set;}
    public DbSet<Brand> Brands {get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        BrandSeeder.Seed(modelBuilder);
    }
}