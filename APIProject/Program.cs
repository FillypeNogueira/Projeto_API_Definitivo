using APIProject.Infrastructure.DependencyInjection;
using APIProject.Domain.Models;
using APIProject.Persistence.Context;
using APIProject.Persistence.Repositores.Interfaces;
using APIProject.Persistence.Repositores;
using APIProject.Services.Interfaces;
using APIProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<DataAppDbContext>();
builder.Services.AddScopedDI();

builder.Services.AddAutoMapper(typeof(Product), typeof(Category));
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
