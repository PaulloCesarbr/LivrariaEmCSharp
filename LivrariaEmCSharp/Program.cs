using LivrariaEmCSharp.Data;
using LivrariaEmCSharp.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//BUILDERS DO SWAGGER (ADICIONAR SEMPRE ANTES DO builder.Build())
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//BILDERS PARA O ENTITY
var connectionString = builder.Configuration.GetConnectionString("ConexaoBanco");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// REGISTRO PARA A INJEÇÃO DE DEPENDENCIA
builder.Services.AddScoped<ILivroRepository, LivroRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
