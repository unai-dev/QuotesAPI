using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuotesAPI.Data;
using QuotesAPI.DTOs;
using QuotesAPI.Models;
using QuotesAPI.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<CreateQuoteDTO, Quote>();
});

builder.Services.AddCors(o =>
{
    o.AddDefaultPolicy(cors =>
    {
        cors.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}


// ENDPOINT de prueba
app.UseCors();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
