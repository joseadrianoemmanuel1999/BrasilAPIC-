global using System.Text.Json.Serialization;  
global using BrasilAPIC_.Interfaces;
global using BrasilAPIC_.Models;
global using BrasilAPIC_.DTO;
global using BrasilAPIC_.Service;
global using BrasilAPIC_.Rest;
global using System.Dynamic;
global using BrasilAPIC_.Mappings;
global using AutoMapper;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IBancoService,BancoService>();
builder.Services.AddSingleton<IEnderecoService,EnderecoService>();
builder.Services.AddSingleton<IBrasilApi,BrasilApiRest>();
builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));

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
