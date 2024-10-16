using Demo.Connection;
using Demo.HelperFunctions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IUtilityFunctions, UtilityFunctions>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//var connectionString = builder.Configuration.GetConnectionString("DBConnectionString");
builder.Services.AddScoped<IConnection, Connection>();

//builder.Services.AddScoped<Connection>(

//e => new Connection(builder.Configuration.GetConnectionString("DBConnectionString")));
var app = builder.Build();

var utility= app.Services.GetService<IUtilityFunctions>();
utility.writeToMySQL();

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
  

    //required using Microsoft.Extensions.DependencyInjection;  
    // required using Microsoft.AspNetCore.Identity;  
    
