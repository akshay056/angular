using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using newegapi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<newegapiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("newegapiContext") ?? throw new InvalidOperationException("Connection string 'newegapiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy(name: "SuperHeroOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("SuperHeroOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
