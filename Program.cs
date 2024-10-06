using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Repositories.Interfaces;
using TechStore_BackEnd.Services;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var uid = Environment.GetEnvironmentVariable("DB_UID");
var database = Environment.GetEnvironmentVariable("DB_DATABASE");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={database};uid={uid};password={password}";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddScoped<IShipmentRepository, ShipmentServices>();
builder.Services.AddScoped<ShipmentServices>();
builder.Services.AddScoped<ICarrierRepository, CarrierServices>(); 
builder.Services.AddScoped<CarrierServices>();
builder.Services.AddScoped<IBrandRepository, BrandServices>();
builder.Services.AddScoped<BrandServices>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "TechStore", Version = "v1" });
        c.SwaggerDoc("v2", new OpenApiInfo { Title = "TechStore", Version = "v2" });
        c.EnableAnnotations();
    }
);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1");
            options.SwaggerEndpoint("/swagger/v2/swagger.json", "Version 2");
        }
    );
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();