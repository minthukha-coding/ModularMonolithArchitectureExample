using Microsoft.AspNetCore.Mvc.ApplicationParts;
using ProductModule.Api.Controllers;
using ProductModule.Application.Interfaces;
using ProductModule.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ProductsController).Assembly));

builder.Services.AddScoped<IProductService, ProductService>();

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
