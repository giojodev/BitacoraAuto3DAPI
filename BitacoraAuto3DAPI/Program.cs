using BitacoraAuto3D.Db.Models;
using BitacoraAuto3D.Db.Models.Models;
using BitacoraAuto3D.Infraestructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using BitacoraAuto3DAPI.Settings;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString= builder.Configuration.GetConnectionString("DbBitacora");
builder.Services.AddDbContext<BITACORA3DContext>(x=>x.UseSqlServer(connectionString));

//Suscripcion de los servicios
builder.Services.AddCatalogServices();
builder.Services.AddProcedureServices();

#region Allow-Origin
builder.Services.AddCors(c=>{
    c.AddPolicy("AllowOrigin",options=>options.AllowAnyOrigin());
});
#endregion

// builder.Services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));

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
