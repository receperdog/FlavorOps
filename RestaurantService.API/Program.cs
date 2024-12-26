using Microsoft.EntityFrameworkCore;
using RestaurantService.Data;
using RestaurantService.Data.Repositories.Implementations;
using RestaurantService.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Why? Enables controller supports.
builder.Services.AddControllers();

builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();

builder.Services.AddDbContext<FlavorOpsDbContext>(options => options.UseInMemoryDatabase("FlavorOpsTestDB"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();


app.Run();
