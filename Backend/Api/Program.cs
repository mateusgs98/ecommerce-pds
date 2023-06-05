using Api.Adaptadores.BD;
using Microsoft.EntityFrameworkCore;
using Dominio.Portas.Entrada;
using Api.Adaptadores.BD.Repositorios;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContextoBd>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
builder.Services.AddScoped<IRepositorioAtendimento, RepositorioAtendimento>();

builder.Services.AddCors(options =>
{
    var policeBuilder = new CorsPolicyBuilder();
    var SmarVactPolice = policeBuilder
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .Build();

    options.AddPolicy(name: "SmartVacPolice", SmarVactPolice);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseCors("SmartVacPolice");

app.UseAuthorization();

app.MapControllers();

app.Run();
