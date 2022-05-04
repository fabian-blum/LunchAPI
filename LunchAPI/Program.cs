using LunchAPI.Models;
using LunchAPI.Repositories.Implementation;
using LunchAPI.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IRepository<Meal>, Repository<Meal>>();
builder.Services.AddSingleton<IRepository<Ingredients>, Repository<Ingredients>>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
