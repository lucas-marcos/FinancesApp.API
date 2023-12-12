using System.Globalization;
using AutoMapper;
using FinancesApp.API.Configurations;
using FinancesApp.API.Data;
using FinancesApp.API.Data.Repositories;
using FinancesApp.API.Interfaces.Repositories;
using FinancesApp.API.Interfaces.Services;
using FinancesApp.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IFinanceService, FinanceService>();
builder.Services.AddScoped<IFinanceRepository, FinanceRepository>();

var config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin 
    .AllowCredentials());

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
