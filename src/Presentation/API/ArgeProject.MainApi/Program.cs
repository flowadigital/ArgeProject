using ArgeProject.Persistence.Data;
using FlowNetFramework.Core;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



if (bool.Parse(builder.Configuration["Redis:EnableRedisCache"]))
{
    builder.Services.AddStackExchangeRedisCache(act =>
    {
        act.Configuration = builder.Configuration["Redis:Config:Database"];
    });
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFlowNetFramework<ArgeDbContext>(builder.Configuration, builder.Host, options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
