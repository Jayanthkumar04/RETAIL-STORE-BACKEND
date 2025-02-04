using Microsoft.EntityFrameworkCore;
using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Repository;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IPowerRepository, PowerRepository>();

builder.Services.AddScoped<IColourRepository, ColourRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
