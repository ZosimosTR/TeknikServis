using Microsoft.EntityFrameworkCore;
using TeknikServis.Business.Services;
using TeknikServis.Core.Interfaces;
using TeknikServis.DataAccess.Context;
using TeknikServis.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<MusteriService>();
builder.Services.AddScoped<CihazService>();
builder.Services.AddScoped<ArizaService>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// baðlantý için girdi
builder.Services.AddDbContext<ServisContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
